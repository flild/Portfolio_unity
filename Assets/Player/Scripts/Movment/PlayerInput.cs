using UnityEngine;
using UnityEngine.InputSystem;

namespace Portfolio.PlayerSpace.Movement
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerControls _playerInput;
        private UnitMoveComponent _movement;
        private void Awake()
        {
            _movement = GetComponent<UnitMoveComponent>();
        }
        private void OnEnable()
        {
            _playerInput = new PlayerControls();
            _playerInput.Enable();
            _playerInput.PlayerMainMap.Jump.performed += OnJump;

        }
        private void Update()
        {
            _movement.Move(GetMoveDirection());
        }
        public Vector3 GetMoveDirection()
        {
            var input = _playerInput.PlayerMainMap.WASD_Move.ReadValue<Vector2>();

            /*if(input.y == 0 && input.x == 0)
            {
                _states.isMove = false;
            }
            else
            {
                _states.isMove = true;
            }*/
            
            Vector3 direction = new Vector3(input.x,0f, input.y);
            return direction;

        }

        private void OnJump(InputAction.CallbackContext context)
        {
            _movement.Jump();
        }
        private void OnDisable()
        {
            _playerInput.PlayerMainMap.Jump.performed -= OnJump;
            _playerInput.Disable();
        }
    }

}
