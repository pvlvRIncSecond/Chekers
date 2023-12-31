using System.Linq;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.Services.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Components.ChekerDesk
{
    public class ChekersField : MonoBehaviour
    {
        private const int CellCount = 8;

        [SerializeField] private float _width;
        [SerializeField] ParticleSystem _particleSystem;
        [SerializeField] Material _prizeMaterial;

        private IInputService _inputService;
        private Camera _camera;

        private Cell[][] _cells = new Cell[CellCount][];
        private float _step;
        private Cell _selectedSell;

        private void Awake()
        {
            _inputService = ServiceLocator.Container.Single<IInputService>();
            _camera = Camera.main;
        }

        private void Start()
        {
            _step = _width * 2 / CellCount;
            var startPos = transform.position - Vector3.forward * (_width - _step / 2) -
                           Vector3.right * (_width - _step / 2);

            CreateCells(startPos);
        }

        private void OnEnable()
        {
            SubscribeCheck();
            SubscribeVerifyingActions();
        }

        private void OnDisable()
        {
            UnsubscribeCheck();
            UnsubscribeVerifyingActions();
        }

        private void CreateCells(Vector3 startPos)
        {
            for (int i = 0; i < CellCount; i++)
            {
                _cells[i] = new Cell[CellCount];

                for (int j = 0; j < CellCount; j++)
                {
                    _cells[i][j] = CreateCellWithIndex(startPos, i, j);
                    _cells[i][j].FindCheker();
                }
            }
        }

        private void CheckCell(InputAction.CallbackContext obj)
        {

            Vector3 screenPoint = new Vector3(_inputService.TouchPosValue0.x, _inputService.TouchPosValue0.y,
                _camera.transform.position.y);
            Vector3 point = _camera.ScreenToWorldPoint(screenPoint);
            Vector3 direction = point - transform.position;

            int coordX = Mathf.FloorToInt(direction.z / _step) + CellCount / 2;
            int coordY = Mathf.FloorToInt(direction.x / _step) + CellCount / 2;

            if (IsOnGrid(coordX, coordY))
            {
                Cell targetedCell = _cells[coordX][coordY];
                if (!targetedCell.IsEmpty && targetedCell.IsPlayable)
                {
                    _selectedSell = targetedCell;
                    Debug.Log($"Select cell x: {coordX} y: {coordY}");
                }
                else if (_selectedSell != null && targetedCell.IsEmpty)
                {
                    _selectedSell.Cheker.position = targetedCell.Center;
                    targetedCell.Cheker = _selectedSell.Cheker;
                    targetedCell.IsEmpty = false;

                    _selectedSell.Clear();

                    _selectedSell = targetedCell;
                }

                Debug.Log($"Cell coords x: {coordX} y: {coordY}");
            }
            else
            {
                _selectedSell = null;
            }

            CheckForPrize();
        }

        private void CheckForPrize()
        {
            var isEmpty = false;
            for (int index = 0; index < CellCount; index++)
            {
                isEmpty &= _cells[index][index].IsEmpty;
            }

            if (!isEmpty)
                GivePrize();
        }

        private void GivePrize()
        {
            Renderer renderer = _particleSystem.GetComponent<Renderer>();
            renderer.material = _prizeMaterial;
        }

        private Cell CreateCellWithIndex(Vector3 startPos, int i, int j) => 
            new(startPos + Vector3.forward * (_step * i) + Vector3.right * (_step * j), _step);

        private void SubscribeVerifyingActions()
        {
            _inputService.Controll.Touchscreen.Touch1Tap.performed += CheckForUnsubscribe;
            _inputService.Controll.Touchscreen.Touch0Tap.performed += CheckForUnsubscribe;
            _inputService.Controll.Touchscreen.Touch1Tap.canceled += CheckForSubscribe;
            _inputService.Controll.Touchscreen.Touch0Tap.canceled += CheckForSubscribe;
        }

        private void UnsubscribeVerifyingActions()
        {
            _inputService.Controll.Touchscreen.Touch1Tap.performed -= CheckForUnsubscribe;
            _inputService.Controll.Touchscreen.Touch0Tap.performed -= CheckForUnsubscribe;
            _inputService.Controll.Touchscreen.Touch1Tap.canceled -= CheckForSubscribe;
            _inputService.Controll.Touchscreen.Touch0Tap.canceled -= CheckForSubscribe;
        }

        private void CheckForSubscribe(InputAction.CallbackContext obj)
        {
            if (_inputService.TouchCount == 0)
                SubscribeCheck();
        }

        private void CheckForUnsubscribe(InputAction.CallbackContext obj)
        {
            if (_inputService.TouchCount > 1)
            {
                UnsubscribeCheck();
                _selectedSell = null;
            }
        }

        private void SubscribeCheck() =>
            _inputService.Controll.Touchscreen.Touch0Tap.canceled += CheckCell;

        private void UnsubscribeCheck() =>
            _inputService.Controll.Touchscreen.Touch0Tap.canceled -= CheckCell;

        private static bool IsOnGrid(int x, int y) =>
            !(((x < 0) || (x >= CellCount)) ||
              ((y < 0) || (y >= CellCount)));


#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            DrawBorders();
            DrawCells();
        }

        private void DrawCells()
        {
            var step = _width * 2 / CellCount;

            for (int index = 1; index < CellCount; index++)
            {
                Debug.DrawLine(transform.position + Vector3.right * (_width - step * index) + Vector3.forward * _width,
                    transform.position + Vector3.right * (_width - step * index) - Vector3.forward * _width, Color.red);

                Debug.DrawLine(transform.position + Vector3.forward * (_width - step * index) + Vector3.right * _width,
                    transform.position + Vector3.forward * (_width - step * index) - Vector3.right * _width, Color.red);
            }
        }

        private void DrawBorders()
        {
            Debug.DrawLine(transform.position + Vector3.right * _width + Vector3.forward * _width,
                transform.position + Vector3.right * _width - Vector3.forward * _width, Color.red);
            Debug.DrawLine(transform.position - Vector3.right * _width + Vector3.forward * _width,
                transform.position - Vector3.right * _width - Vector3.forward * _width, Color.red);
            Debug.DrawLine(transform.position - Vector3.forward * _width + Vector3.right * _width,
                transform.position - Vector3.forward * _width - Vector3.right * _width, Color.red);
            Debug.DrawLine(transform.position + Vector3.forward * _width + Vector3.right * _width,
                transform.position + Vector3.forward * _width - Vector3.right * _width, Color.red);
        }
#endif
    }
}