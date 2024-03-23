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
        [SerializeField, Range(0.1f, 1)]
        private float _mouseSense;
        public float JumpForce
        {
            get => _jumpHeight;
        }
        public float MoveSpeed
        {
            get => _moveSpeed;
        }
        public float MouseSense
        {
            get => _mouseSense;
        }
    }
}

