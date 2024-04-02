using UnityEngine;
using Zenject;

namespace Portfolio
{
    public class ManagerInstaller : MonoInstaller
    {
        [SerializeField]
        private GameManager _gameManager;
        public override void InstallBindings()
        {
            Container.Bind<GameManager>().FromInstance(_gameManager).AsSingle();
        }
    }
}
