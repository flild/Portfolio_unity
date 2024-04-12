using UnityEngine;
using Portfolio.Interfaces;
using Zenject;
using Portfolio.PlayerSpace;

namespace Portfolio.RoomRagdoll
{
    public class RestartBtnView : MonoBehaviour, IUseble, IFocusable
    {
        [Inject]
        private LevelController _levelController;
        [SerializeField]
        private Outline _outline;

        public string FocusInfo => throw new System.NotImplementedException();

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
            _levelController.RestartCurrentLevel();
        }
    }
}

