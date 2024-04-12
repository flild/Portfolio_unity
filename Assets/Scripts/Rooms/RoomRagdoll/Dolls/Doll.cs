using Portfolio.Interfaces;
using System;
using UnityEngine;

namespace Portfolio.RoomRagdoll.Dolls
{
    public class Doll : MonoBehaviour, IHittable
    {
        [SerializeField]
        private DollView _view;
        [SerializeField]
        private RagdollHandler _Ragdollhandler;
        [SerializeField]
        private RagdollColor _dollColor;
        private Transform _mainHips;
        public RagdollColor Color { get { return _dollColor; } }

        private void Awake()
        {
            _view.Initialize(transform);
            _Ragdollhandler.Initialize();
            _mainHips = _view.Animator.GetBoneTransform(HumanBodyBones.Hips);
            _mainHips.GetComponent<DollMainHips>().Color = _dollColor;
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
        public void Alive()
        {
            DisableRagdollBehaviour();
        }
        public void CorrectPosition()
        {
            _view.ChangePositionToMainHips();
        }
        private void EnableRagdollBehaviour()
        {
            _view.DisableAnimator();
            _Ragdollhandler.Enable();
        }
        private void DisableRagdollBehaviour()
        {
            _Ragdollhandler.Disable();
            _view.EnableAnimator();
        }
    }
}

