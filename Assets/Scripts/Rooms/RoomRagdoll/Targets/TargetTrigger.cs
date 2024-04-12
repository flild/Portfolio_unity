using Portfolio.RoomRagdoll.Dolls;
using System;
using UnityEngine;

namespace Portfolio.RoomRagdoll
{
    public class TargetTrigger : MonoBehaviour
    {
        public event Action<RagdollColor> dollDropedInTargetEvent;
        [SerializeField]
        private RagdollColor _targetColor; 
        public RagdollColor Color { get { return _targetColor; } }
        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out DollMainHips doll))
            {
                if (doll.Color == _targetColor)
                    dollDropedInTargetEvent?.Invoke(_targetColor);
            }
        }
    }

}
