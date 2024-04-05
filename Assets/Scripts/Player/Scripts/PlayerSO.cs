using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
        [CreateAssetMenu(fileName = "Player", menuName = "ScriptableObject/Player/Player")]
        public class PlayerSO : ScriptableObject, IDisposable
        {
            [SerializeField]
            private PlayerStatsSO _stats;
            private PlayerView _view;
            [SerializeField]
            private InputReaderSO _input;
            private PlayerControll _movement;
            private PlayerRayCastHandler _rayCastHandler;
        private PlayerAnimation _playerAnimation;
            public void Init(PlayerView view)
            {
                _view = view;
                _playerAnimation = new PlayerAnimation(_view.GetComponent<Animator>());
                _view.Initialize(_playerAnimation);
                _movement = new PlayerControll(_view, _input, _stats, _playerAnimation);
                _rayCastHandler = new PlayerRayCastHandler(_view);
            }
            public PlayerStatsSO GetStats()
            {
                return _stats;
            }

        public void Dispose()
        {
            _movement.Dispose();
        }
    }
}

