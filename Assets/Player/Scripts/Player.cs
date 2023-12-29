using Portfolio.PlayerSpace.Movement;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private PlayerStats _stats;
        private UnitMoveComponent _movement;
        private PlayerInput _input;
        public PlayerStats GetStats()
        {
            return _stats;
        }

    }
}

