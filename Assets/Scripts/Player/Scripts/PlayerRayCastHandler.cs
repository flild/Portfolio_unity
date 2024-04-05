using Portfolio.Interfaces;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class PlayerRayCastHandler
    {
        private PlayerView _view;
        public PlayerRayCastHandler(PlayerView view)
        {
            _view = view;
            _view.RaycastEvent += RaycastHandler;
        }
        private void RaycastHandler(RaycastHit hit)
        {
            if(hit.collider == null)
            {
                return;
            }
        }
    }
}

