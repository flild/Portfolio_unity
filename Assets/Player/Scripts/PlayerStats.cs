using UnityEngine;
using Portfolio.Extensions;

namespace Portfolio.PlayerSpace
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField]
        private float _moveSpeed;
        [SerializeField]
        private float _jumpHeight;
        public float JumpHeight
        {
            get => _jumpHeight;
            private set => _moveSpeed = value;
        }
        public float MoveSpeed
        {
            get => _moveSpeed;
            private set => _moveSpeed = value;
        }
    }
}

