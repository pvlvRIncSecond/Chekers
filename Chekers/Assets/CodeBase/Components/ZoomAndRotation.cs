using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.Services.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Components
{
    public class ZoomAndRotation : MonoBehaviour
    {
        [SerializeField] private int _rotationThreshold = 15;
        [SerializeField] private float _rotationSensitivity = .03f;
        [SerializeField] private float _zoomSensitivity;
        [SerializeField] private float _minZoom;
        [SerializeField] private float _maxZoom;

        private IInputService _inputService;
        private Camera _camera;
        private float _prevMagnitude = 0;

        private void Awake()
        {
            _inputService = ServiceLocator.Container.Single<IInputService>();
            _camera = Camera.main;
        }

        private void OnEnable()
        {
            _inputService.Controll.Touchscreen.Touch0Tap.canceled += ClearMagnitude;
            _inputService.Controll.Touchscreen.Touch1Tap.canceled += ClearMagnitude;
            _inputService.Controll.Touchscreen.TouchPos1.performed += ZoomAndRotate;
        }

        private void OnDisable()
        {
            _inputService.Controll.Touchscreen.Touch0Tap.canceled -= ClearMagnitude;
            _inputService.Controll.Touchscreen.Touch1Tap.canceled -= ClearMagnitude;
            _inputService.Controll.Touchscreen.TouchPos1.performed -= ZoomAndRotate;
        }

        private void ZoomAndRotate(InputAction.CallbackContext obj)
        {
            if (_inputService.TouchCount < 2)
                return;

            var magnitude = (_inputService.TouchPosValue0 - _inputService.TouchPosValue1).magnitude;

            if (_prevMagnitude == 0)
                _prevMagnitude = magnitude;

            var difference = magnitude - _prevMagnitude;
            _prevMagnitude = magnitude;

            Debug.Log(magnitude);


            {
                var angle = CalculateAngle();
                // if (angle > _rotationThreshold)
                    CameraRotate(angle);
            }

            CameraZoom(-difference * _zoomSensitivity);
        }

        private float CalculateAngle()
        {
            Vector2 prevTouch0 = _inputService.TouchPosValue0 - _inputService.TouchDeltaValue0;
            Vector2 prevTouch1 = _inputService.TouchPosValue1 - _inputService.TouchDeltaValue1;
            
            Vector2 prevDirection = prevTouch1 - prevTouch0;
            Vector2 currentDirection = _inputService.TouchPosValue1 - _inputService.TouchPosValue0;
            
            float angle = Vector2.SignedAngle(prevDirection, currentDirection) * Mathf.Rad2Deg;
            if (Mathf.Abs(angle) < _rotationThreshold)
                angle = 0.0f;
            
            angle = Mathf.Clamp(angle * _rotationSensitivity, -1.0f, 1.0f);
            
            return angle;
        }

        private void CameraRotate(float angle) =>
            _camera.transform.RotateAround(_camera.transform.position, -_camera.transform.forward,
                angle);

        private void CameraZoom(float increment) =>
            _camera.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView + increment, _minZoom, _maxZoom);

        private void ClearMagnitude(InputAction.CallbackContext obj) =>
            _prevMagnitude = 0;
    }
}