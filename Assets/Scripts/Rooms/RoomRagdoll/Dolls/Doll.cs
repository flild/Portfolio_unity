using System;
using UnityEngine;

namespace Portfolio.RoomRagdoll.Dolls
{
    public class Doll : MonoBehaviour
    {
        [SerializeField]
        private DollView _view;
        [SerializeField]
        private RagdollHandler _Ragdollhandler;

        private void Awake()
        {
            _view.Initialize();
            _Ragdollhandler.Initialize();
        }
        public void Kill()
        {
            _view.DisableAnimator();
            _Ragdollhandler.Enable();
        }
        public void TakeHit(Vector3 force, Vector3 hitPoint)
        {
            EnableRagdollBehaviour();
            _Ragdollhandler.Hit(force, hitPoint);
        }

        private void EnableRagdollBehaviour()
        {
            _view.DisableAnimator();
            _Ragdollhandler.Enable();
        }
    }
}

