using UnityEngine;
using Zenject;

namespace Portfolio
{
    public class GameLogicInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<LevelController>().AsSingle();
        }
    }
}
