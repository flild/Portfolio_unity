using Portfolio.Interfaces;
using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class PlayerControll: IDisposable
    {
        private Rigidbody _rb;
        private PlayerView _view;
        private InputReaderSO _input;
        private PlayerStatsSO _stats;
        private CameraControll _camera;
        private PlayerAnimation _animationView;
        private Vector3 calcDirection;
        private Vector2 inputDirection;



        public PlayerControll(PlayerView view, InputReaderSO input, PlayerStatsSO stats, PlayerAnimation playerAnimation)
        {
            _view = view;
            _input = input;
            _stats = stats;
            _rb = _view.GetComponent<Rigidbody>();
            _animationView = playerAnimation;
            _camera = new CameraControll(_view.GetComponentInChildren<Camera>(), _stats.MouseSense);
            Init();
        }
        private void Init()
        {

            _input.MoveEvent += OnMove;
            _input.JumpEvent += OnJump;
            _input.MouseMove += OnMouseMove;
            _view.FixedUpdateEvent += OnFixedUpdate;
            _input.UseItemEvent += OnUseItem;
        }
        private void OnFixedUpdate()
        {
            calcDirection = _rb.transform.forward * inputDirection.y + _rb.transform.right * inputDirection.x;
            calcDirection = calcDirection * _stats.MoveSpeed * Time.deltaTime;
            _rb.velocity = new Vector3(calcDirection.x, _rb.velocity.y, calcDirection.z);
        }
        private void OnMove(Vector2 direction)
        {
            _animationView.Move(direction);
            inputDirection = direction;
        }
        private void OnJump()
        {
            _rb.AddForce(Vector3.up * _stats.JumpForce, ForceMode.Acceleration);
        }
        private void OnMouseMove(Vector2 dir)
        {
            _rb.transform.Rotate(Vector3.up, dir.x * _stats.MouseSense);
            _camera.Rotate(dir);

        }
        private void OnUseItem()
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.TryGetComponent(out IUseble item))
                {
                    item.Use(_view);
                }
            }
        }
        public void Dispose()
        {
            _input.MoveEvent -= OnMove;
            _input.JumpEvent -= OnJump;
            _input.MouseMove -= OnMouseMove;
            _view.FixedUpdateEvent -= OnFixedUpdate;
        }
    }
}

