using Portfolio.Extensions;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [CreateAssetMenu(fileName = "PlayerStatsData", menuName = "ScriptableObject/Player/StatsData", order = 102)]
    public class PlayerStatsSO: ScriptableObject
    {
        [SerializeField]
        private float _moveSpeed;
        [SerializeField]
        private float _jumpHeight;
        public float JumpForce
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

