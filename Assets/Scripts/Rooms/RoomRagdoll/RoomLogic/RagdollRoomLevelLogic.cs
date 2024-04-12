using AYellowpaper.SerializedCollections;
using Portfolio.RoomRagdoll.Dolls;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll
{
    public class RagdollRoomLevelLogic : MonoBehaviour
    {
        [Inject]
        private LevelController _levelController;
        [SerializeField]
        private SerializedDictionary<RagdollColor, Doll> _dollsMap;
        [SerializeField]
        private SerializedDictionary<RagdollColor, TargetTrigger> _targetsMap;
        [SerializeField]
        private List<LevelPlatforms> _levelsList;
        [SerializeField]
        private List<RagdollLevelSettigsSO> _settings;
        private int _currentLevelIndex =1;
        private TargetHitTracker _targetHitTraker;
        private ObjectMoverAssistant _moveAssistent;
        private void Start()
        {
            Initialize();
            LoadLevel(0);
        }
        public void Initialize()
        {
            _targetHitTraker = new TargetHitTracker(new Dictionary<RagdollColor, TargetTrigger>(_targetsMap));
            _moveAssistent = new();
            _targetHitTraker.AllTargetHitted += Levelcomplete;
            _levelController.LevelChangedEvent += LoadLevel;
            _levelController.RestartLevelEvent += RestartLevel;
        }
        private void Levelcomplete()
        {
            _levelController.NextLevel();
        }
        public void LoadLevel(int value)
        {
            if (value == _currentLevelIndex)
                return;
            if (value >= _levelsList.Count)
            {
                _levelController.LastLevelEnded();
            }
            _levelsList[_currentLevelIndex].gameObject.SetActive(false);
            _currentLevelIndex = value;
            _levelsList[value].gameObject.SetActive(true);
            ReplaceDolls();
            ReplaceHoles();
        }
        private async void ReplaceDolls()
        {
            //доделать, чтобы куклы плавно перетаскивались к нужному месту
            //var tasks = new List<Task>();
            //foreach (var doll in _dollsMap)
            //{
            //    doll.Value.CorrectPosition();
            //}
            //foreach (var doll in _dollsMap)
            //{
             //   tasks.Add(_moveAssistent.MoveDollAsync(doll.Value.transform, _settings[_currentLevelIndex].DollsPositions[doll.Key]));
            //}
            //await Task.WhenAll(tasks);
            foreach (var doll in _dollsMap)
            {
                doll.Value.transform.position = _settings[_currentLevelIndex].DollsPositions[doll.Key];
                doll.Value.Alive();
            }
        }
        private void ReplaceHoles()
        {
            foreach (var target in _targetsMap)
            {
                _moveAssistent.MoveDollAsync(target.Value.transform, _settings[_currentLevelIndex].HolesPositions[target.Key]);
            }
        }
        private void RestartLevel()
        {
            ReplaceDolls();
            ReplaceHoles();
            _targetHitTraker.RestartLevel();
        }
        private void OnDisable()
        {
            //переделать, чтобы отписка происходила когда плеер выхоидт ищ румы
            _targetHitTraker.AllTargetHitted -= Levelcomplete;
            _levelController.LevelChangedEvent -= LoadLevel;
            _levelController.RestartLevelEvent -= RestartLevel;
        }
    }   
}
