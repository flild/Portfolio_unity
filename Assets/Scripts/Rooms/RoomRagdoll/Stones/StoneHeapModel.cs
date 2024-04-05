using Portfolio.PlayerSpace;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneHeapModel: IInitializable
    {
        private StoneHeapView _view;
        [Inject]
        private StoneInWorldController _stoneController;
        public StoneHeapModel(StoneHeapView view)
        {
            _view = view;
            Debug.Log(_view);
            _view.PlayerTakeStone += OnPlayerTakeStone;
        }

        public void Initialize()
        {
        }

        private void OnPlayerTakeStone(PlayerView player)
        {
            _stoneController.SetCurrentStone(GameObject.Instantiate(_view.StonePrefab));
        }
    }
}


