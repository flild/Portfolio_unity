using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [RequireComponent(typeof(Rigidbody),typeof(Animator))]
    public class PlayerView : MonoBehaviour
    {
        public event Action FixedUpdateEvent;
        private void FixedUpdate()
        {
            FixedUpdateEvent?.Invoke();
        }

    }
}


