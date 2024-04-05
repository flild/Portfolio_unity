using UnityEngine;
using Portfolio.PlayerSpace;
using Zenject;


namespace Portfolio
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField]
        private PlayerView _playerView;

        public override void InstallBindings()
        {
            Container.BindInstance(_playerView).AsSingle();
        }
    }
}

