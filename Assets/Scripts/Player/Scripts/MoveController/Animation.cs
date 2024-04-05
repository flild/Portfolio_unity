using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class PlayerAnimation
    {
        private Animator _animator;
        private bool _isMoving;

        private readonly int _IdSpeedX = Animator.StringToHash("SpeedX");
        private readonly int _IdSpeedY = Animator.StringToHash("SpeedY");
        private readonly int _IdIsMoving = Animator.StringToHash("IsMoving");
        //IsMoving
        public PlayerAnimation(Animator animator)
        {
            if (animator == null)
                Debug.LogError("animator in Animation is null");
            _animator = animator;   
        }

        public void Move(Vector2 dir)
        {
            if(dir.x == 0 && dir.y == 0)
            {
                _isMoving = false;
                _animator.SetBool(_IdIsMoving, _isMoving);
            }
            else
            {
                _isMoving = true;
                _animator.SetBool(_IdIsMoving, _isMoving);
                _animator.SetFloat(_IdSpeedY, dir.y);
                _animator.SetFloat(_IdSpeedX, dir.x);
            }
        }
        public void SetCustomAnimator(RuntimeAnimatorController animator)
        {
            //вообще дичь, аниматор сам должен возразать дефолтное значение, когда надо
            _animator.runtimeAnimatorController = animator;
        }
        public void PlayCustomAnimation(int animId)
        {
            _animator.SetTrigger(animId);
        }
        public void PlayCustomAnimation(int animId, bool value)
        {
            _animator.SetBool(animId, value);
        }
    }
}

