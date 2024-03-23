using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class Movement: IDisposable
    {
        private Rigidbody _rb;
        private InputReaderSO _input;
        private PlayerStatsSO _stats;

        private Vector3 calcDirection;

        public Movement(Rigidbody rigidbody, InputReaderSO input, PlayerStatsSO stats)
        {
            _rb = rigidbody;
            _input = input;
            _stats = stats;
            Init();
        }
        private void Init()
        {
            _input.MoveEvent += OnMove;
            _input.JumpEvent += OnJump;
        }
        private void OnMove(Vector2 direction)
        {
            calcDirection = _rb.transform.forward * direction.y + _rb.transform.right * direction.x;
            _rb.velocity = calcDirection * _stats.MoveSpeed * Time.deltaTime;
        }
        private void OnJump()
        {
            _rb.AddForce(Vector3.up * _stats.JumpForce);
        }

        public void Dispose()
        {
            _input.MoveEvent -= OnMove;
            _input.JumpEvent -= OnJump;
        }
    }
}

