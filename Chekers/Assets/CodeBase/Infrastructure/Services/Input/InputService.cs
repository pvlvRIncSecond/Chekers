using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Infrastructure.Services.Input
{
    public class InputService : IInputService
    {
        public Controll Controll => _controll;
        public int TouchCount => _touchCount;
        public Vector2 TouchPosValue0 => _touchPosValue0;
        public Vector2 TouchPosValue1 => _touchPosValue1;
        public Vector2 TouchDeltaValue0 => _touchDeltaValue0;
        public Vector2 TouchDeltaValue1 => _touchDeltaValue1;
        
        private Controll _controll;
        private int _touchCount = 0;
        
        private Vector2 _touchPosValue0;
        private Vector2 _touchPosValue1;
        private Vector2 _touchDeltaValue0;
        private Vector2 _touchDeltaValue1;

        public InputService()
        {
            _controll = new Controll();
            _controll.Enable();
            
            SubscribeOnActions();
        }

        private void SubscribeOnActions()
        {
            _controll.Touchscreen.Touch0Tap.performed += IncrementTouchCount;
            _controll.Touchscreen.Touch1Tap.performed += IncrementTouchCount;

            _controll.Touchscreen.Touch0Tap.canceled += DecrementTouchCount;
            _controll.Touchscreen.Touch1Tap.canceled += DecrementTouchCount;

            _controll.Touchscreen.TouchPos0.performed += ReadTouch0Pos;
            _controll.Touchscreen.TouchPos1.performed += ReadTouch1Pos;
            
            _controll.Touchscreen.TouchPos0.performed += ReadTouch0Delta;
            _controll.Touchscreen.TouchPos1.performed += ReadTouch1Delta;
        }

        private void ReadTouch0Delta(InputAction.CallbackContext obj) => 
            _touchDeltaValue0 = _controll.Touchscreen.TouchDelta0.ReadValue<Vector2>();

        private void ReadTouch1Delta(InputAction.CallbackContext obj) => 
            _touchDeltaValue1 = _controll.Touchscreen.TouchDelta1.ReadValue<Vector2>();

        private void ReadTouch1Pos(InputAction.CallbackContext obj) => 
            _touchPosValue1 = _controll.Touchscreen.TouchPos1.ReadValue<Vector2>();

        private void ReadTouch0Pos(InputAction.CallbackContext obj) => 
            _touchPosValue0 = _controll.Touchscreen.TouchPos0.ReadValue<Vector2>();

        private void DecrementTouchCount(InputAction.CallbackContext obj) => 
            _touchCount--;

        private void IncrementTouchCount(InputAction.CallbackContext obj) => 
            _touchCount++;
    }
}