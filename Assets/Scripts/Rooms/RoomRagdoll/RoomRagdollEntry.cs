using Portfolio.PlayerSpace;
using Portfolio.RoomRagdoll.Dolls;
using Portfolio.RoomRagdoll.Stones;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll
{
    public class RoomRagdollEntry : MonoBehaviour
    {
        [SerializeField]
        private Doll _doll;
        [SerializeField]
        private float _force;
        [SerializeField]
        private StoneHeapView _stoneHeapView;
        [Inject]
        private StoneHeapModel _stoneHeapModel;
        [Inject]
        private GameManager _gameManager;
        [Inject]
        private PlayerView _player;
        [SerializeField]
        private RuntimeAnimatorController _customAnimator;
        [SerializeField]
        //������ ����, �������� ��� ������ ��������� ��������� ��������, ����� ����
        private RuntimeAnimatorController _deafaultPlayrAnimation;
        private void Start()
        {
            //������ ����, �������� ��� ������ ��������� ��������� ��������, ����� ����
            _player.AnimationController.SetCustomAnimator(_customAnimator);
        }
    }
}

