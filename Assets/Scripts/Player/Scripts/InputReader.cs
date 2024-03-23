using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Portfolio
{
    public class InputReaderSO : ScriptableObject, PlayerControls.IPlayerMainMapActions
    {
        private PlayerControls _gameInput;
        public event Action<Vector2> MoveEvent;
        public event Action JumpEvent;

        private void OnEnable()
        {
            _gameInput ??= new PlayerControls();
            _gameInput.PlayerMainMap.SetCallbacks(this);
            EnableMainMap();
        }
        public void EnableMainMap()
        {
            _gameInput.Enable();
        }
        public void DisableMainMap()
        {
            _gameInput.Enable();
        }
        public void OnJump(InputAction.CallbackContext context)
        {
            if (context.phase == InputActionPhase.Performed)
            {
                JumpEvent?.Invoke();
            }
        }

        public void OnWASD_Move(InputAction.CallbackContext context)
        {
            MoveEvent?.Invoke(context.ReadValue<Vector2>());
        }
    }
}


