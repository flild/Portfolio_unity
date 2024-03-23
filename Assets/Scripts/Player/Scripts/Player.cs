using Portfolio.Extensions;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [CreateAssetMenu(fileName = "Player", menuName = "ScriptableObject/Player/Player")]
    public class Player: ScriptableObject
    {
        [SerializeField]
        private PlayerStatsSO _stats;
        private PlayerView _view;
        [SerializeField]
        private InputReaderSO _input;
        private Movement _movement;
        public void Init(PlayerView view)
        {
            _view = view;
            _movement = new Movement(_view.Rigidbody, _input, _stats);
        }
        public PlayerStatsSO GetStats()
        {
            return _stats;
        }

    }
}

