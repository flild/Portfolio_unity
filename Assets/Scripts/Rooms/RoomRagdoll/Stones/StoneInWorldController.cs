using Portfolio.Extensions;
using Portfolio.PlayerSpace;
using System;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneInWorldController : IInitializable
    {
        private StoneView _stoneMesh;
        [Inject]
        private StonePhysic _stonePhysic;
        [Inject]
        private PlayerView _player;
        [Inject]
        private InputReaderSO _input;
        private PlayerAnimation _playerAnimation;
        private StoneThrowTrajectoryCalculator _calculator;
        private Transform _handPosition;
        private Transform _head;
        private float _force = 80;
        private Vector3 direction;
        private float _headOffset = 0.5f;
        private float _stoneMass = 3;
        private float _launchSpeed;
        private readonly int _IdCustomAnimationThrow = Animator.StringToHash("Throw");


        public void Initialize()
        {
            _head = _player.GetBodyPart(PlayerBodyParts.head);
            _handPosition = _player.GetBodyPart(PlayerBodyParts.righthand);
            _playerAnimation = _player.AnimationController;
            _calculator = new();
            _launchSpeed = _force / _stoneMass;
            _input.MainActionEvent += OnMainAction;
        }

        private void OnMainAction()
        {
            Throw();
        }

        public void SetCurrentStone(StoneView stone)
        {
            Debug.Log("Player take stone");
            _stoneMesh = stone;
            _stoneMesh.transform.position = _handPosition.position;
            _stoneMesh.transform.parent = _handPosition;
            _stoneMesh.EnableLine();
            _player.BigRaycastEvent += CalculateTrajectory;
        }
        private void CalculateTrajectory(RaycastHit hit)
        {
            if(hit.collider == null)
            {
                return;
            }
            Vector3 stonePos = _head.position +_player.transform.right * _headOffset;
            direction = hit.point - stonePos;
            float targetHeight = hit.point.y - stonePos.y;
            float angle = Mathf.Atan((2 * targetHeight) / (_launchSpeed * _launchSpeed / -Physics.gravity.y)) * Mathf.Rad2Deg;
            direction = Quaternion.AngleAxis(angle, _player.transform.right)*direction;
            Vector3[] points = _calculator.CalcuteTrajectory(stonePos, direction.normalized* _launchSpeed);
            _stoneMesh.SetLine(points);
        }
        public void Throw()
        {
            _playerAnimation.PlayCustomAnimation(_IdCustomAnimationThrow);
            _player.BigRaycastEvent -= CalculateTrajectory;
            var stone = GameObject.Instantiate(_stonePhysic, _head.position + _player.transform.right* _headOffset, Quaternion.identity);
            _stoneMesh.DisableLine();
            GameObject.Destroy(_stoneMesh.gameObject);
            _stoneMesh = null;
            stone.GetComponent<Rigidbody>().AddForce(direction.normalized* _force, ForceMode.Impulse);
        }


    }
}

