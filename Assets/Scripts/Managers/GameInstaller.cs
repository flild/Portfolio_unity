using UnityEngine;
using Portfolio.PlayerSpace;
using Zenject;


namespace Portfolio
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField]
        private Player _player;

        public override void InstallBindings()
        {
            Container.BindInstance(_player).AsSingle();

        }
    }
}

