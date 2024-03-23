using UnityEngine;
using Portfolio.PlayerSpace;
using Zenject;


namespace Portfolio
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField]
        private PlayerSO _player;

        public override void InstallBindings()
        {
            Container.BindInstance(_player).AsSingle();

        }
    }
}

