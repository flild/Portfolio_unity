using System;
using UnityEngine;

namespace Portfolio
{
    public class LevelController
    {
        //Levels start since 0
        private int _currentLevel = 0;
        public event Action<int> LevelChangedEvent;
        public event Action RestartLevelEvent;

        public void RestartCurrentLevel()
        {
            RestartLevelEvent?.Invoke();
        }
        public void NextLevel()
        {
            _currentLevel++;
            LevelChangedEvent.Invoke(_currentLevel);
        }
        public void SetCurrentLevel(int value)
        {
            _currentLevel = value;
        }
        public int GetCurrentLevel()
        {
            return _currentLevel;
        }
        public void LastLevelEnded()
        {
            //некст рума или разрешение в некст руму
        }
    }
}

