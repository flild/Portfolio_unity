using Portfolio.Interfaces;
using Portfolio.PlayerSpace;
using System;
using UnityEngine;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneHeapView : MonoBehaviour, IUseble
    {
        [SerializeField]
        private StoneView _stoneMesh;
        [SerializeField]
        private StonePhysic _stonePhysic;
        public StoneView StonePrefab { get => _stoneMesh; }
        public StonePhysic StonePhysicPrefab { get => _stonePhysic; }
        public event Action<PlayerView> PlayerTakeStone;
        public void Use(PlayerView player)
        {
            PlayerTakeStone?.Invoke(player);
        }
        
    }
}

