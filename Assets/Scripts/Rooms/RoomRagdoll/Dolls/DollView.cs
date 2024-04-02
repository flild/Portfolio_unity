using UnityEngine;

namespace Portfolio.RoomRagdoll.Dolls
{
    [RequireComponent(typeof(Animator))]
    public class DollView : MonoBehaviour
    {
        private Animator _animator;
        public void Initialize() => _animator = GetComponent<Animator>();
        
        public void DisableAnimator() => _animator.enabled = false;
        public void EnableAnimator() => _animator.enabled = true;
    }
}

