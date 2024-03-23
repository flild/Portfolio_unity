using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; private set; }
        public event Action FixedUpdateEvent;
        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            FixedUpdateEvent?.Invoke();
        }

    }
}


