using Portfolio.Interfaces;
using Portfolio.PlayerSpace;
using System;
using UnityEngine;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneHeapView : MonoBehaviour, IUseble, IFocusable
    {
        [SerializeField]
        private StoneView _stoneMesh;
        [SerializeField]
        private StonePhysic _stonePhysic;
        [SerializeField]
        private Outline _outline;
        public StoneView StonePrefab { get => _stoneMesh; }
        public StonePhysic StonePhysicPrefab { get => _stonePhysic; }

        public string FocusInfo => "Взять камень Е";

        public event Action<PlayerView> PlayerTakeStone;

        public void Focus()
        {
            _outline.enabled = true;
        }

        public void UnFocus()
        {
            _outline.enabled = false;
        }

        public void Use(PlayerView player)
        {
            PlayerTakeStone?.Invoke(player);
        }
        
    }
}

