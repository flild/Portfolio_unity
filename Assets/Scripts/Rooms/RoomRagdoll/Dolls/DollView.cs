using UnityEngine;

namespace Portfolio.RoomRagdoll.Dolls
{
    [RequireComponent(typeof(Animator))]
    public class DollView : MonoBehaviour
    {
        private Animator _animator;
        private Transform _parent;
        private Transform _hipsBone;
        public Animator Animator { get => _animator; }
        public void Initialize(Transform parent)
        {
            _animator = GetComponent<Animator>();
            _parent = parent;
            _hipsBone = _animator.GetBoneTransform(HumanBodyBones.Hips);
        } 
        public void ChangePositionToMainHips()
        {
            Vector3 initHipsPosition = _hipsBone.position;
            _parent.position = initHipsPosition;
            _hipsBone.position = initHipsPosition;
        }
        public void DisableAnimator() => _animator.enabled = false;
        public void EnableAnimator() => _animator.enabled = true;
    }
}

