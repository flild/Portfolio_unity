using Portfolio.RoomRagdoll.Stones;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll
{
    public class RagdollRoomInstaller : MonoInstaller
    {
        [SerializeField]
        private InputReaderSO _inputReader;
        [SerializeField]
        private StonePhysic _stonePhysicPrefab;
        [SerializeField]
        private StoneHeapView _stoneHeapView;
        public override void InstallBindings()
        {
            Container.Bind<InputReaderSO>().FromInstance(_inputReader).AsSingle();
            Container.Bind<StonePhysic>().FromInstance(_stonePhysicPrefab).AsSingle();
            Container.BindInterfacesAndSelfTo<StoneInWorldController>().AsSingle();
            Container.BindInterfacesAndSelfTo<StoneHeapModel>().AsSingle().WithArguments(_stoneHeapView);
        }
    }
}
