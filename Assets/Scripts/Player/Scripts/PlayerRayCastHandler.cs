using Portfolio.Interfaces;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class PlayerRayCastHandler
    {
        private PlayerView _view;
        private IFocusable _currentFocusableObject;
        public PlayerRayCastHandler(PlayerView view)
        {
            _view = view;
            _view.SmallRaycastEvent += RaycastHandler;
        }
        private void RaycastHandler(RaycastHit hit)
        {
            if (hit.collider == null)
            {
                _currentFocusableObject?.UnFocus();
                _currentFocusableObject = null;
                return;
            }
            else if(hit.collider.TryGetComponent(out IFocusable focusableObject))
            {
                if(focusableObject == _currentFocusableObject)
                {
                    return;
                }
                _currentFocusableObject?.UnFocus();
                focusableObject.Focus();
                _currentFocusableObject = focusableObject;
            }
            else
            {
                _currentFocusableObject?.UnFocus();
                _currentFocusableObject = null;
            }
            
        }
    }
}

