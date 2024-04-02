using Portfolio.PlayerSpace;
using UnityEngine;

namespace Portfolio
{
    public class GameManager : MonoBehaviour
    {
        private LevelController _levelController;
        [SerializeField]
        private SceneController _sceneController;
        [SerializeField]
        private PlayerView _playerView;
        [SerializeField]
        private PlayerSO _player;


        private void Awake()
        {
            _levelController = new LevelController(_sceneController);
            _levelController.LoadNextLevel();
            _player.Init(_playerView);
            _playerView.transform.position = new Vector3(0f,1f, 0f);    // spawn �� ����� ������ ������, ����������� � ������
            
        }
        public PlayerView GetPlayerView { get { return _playerView; } }
        private void OnDestroy()
        {
            _player.Dispose();
        }

        //todo list
        /*
         * 1. scenecondition ������� ��� ������� ���� �������� � ������ ��� ���� �� ����
         * 2. ����� �������������
         * 
         * 
         */

    }

}
