using UnityEngine;
using Portfolio.Extensions;
using Zenject;
using static Portfolio.Extensions.Extensions;

namespace Portfolio.PlayerSpace.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class UnitMoveComponent : MonoBehaviour
    {
        private Rigidbody _rb;
        //private View.UnitViewComponent _view;
        private Player _player;

        //jump
        private float _Yspeed;
        private bool _isGrounded = true;


        private Vector3 calcDirection;

        #region Unity Callbacks
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();

        }
        private void FixedUpdate()
        {
            CheckYSpeed();
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (_isGrounded) return;
            //todo чуть более гибкая проверка нормали, прыжки от косых поверхностей
            if (collision.contacts[0].normal == Vector3.up)
            {
                _isGrounded = true;
                //_view.LandingAnim();
            }
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            if(calcDirection !=null)
            {
                Gizmos.DrawLine(transform.position, transform.position + calcDirection*3);
            }
            
        }
        private void OnValidate()
        {
            if (_player == null)
                _player = GetComponent<Player>();
        }
        #endregion
        public void Move(Vector3 direction)
        {
            if (_isGrounded)
            {
                calcDirection = transform.forward * direction.z + transform.right * direction.x;
                if(true)//_states.isSprinting)
                {
                    _rb.velocity = calcDirection * _player.GetStats().MoveSpeed * Time.deltaTime * constants.MoveSpeedRatio;//_stats.SprintSpeed домножение на это
                }
                else
                { 
                    _rb.velocity = calcDirection * _player.GetStats().MoveSpeed * Time.deltaTime * constants.MoveSpeedRatio;
                }
                    
                //_view.MoveAnim(direction);
            }
                
        }
        #region Jump
        public void Jump()
        {
            if (_isGrounded)
            {
                //_view.JumpAnim();
                _rb.AddForce(Vector3.up * _player.GetStats().JumpHeight * constants.JumpRatio, ForceMode.Impulse);
                _isGrounded = false;
            }

        }
        public void CheckYSpeed()
        {
            _Yspeed = _rb.velocity.y;
            if (_Yspeed < -1)
            {
                //_view.FallAnim();
            }

        } 
        #endregion
        public void OnEndAnyAnimation()
        {
            //_inAnimation = false;
           
        }
        public void UnitInAnimation()
        {
            //_inAnimation = true;
        }
    }
}

