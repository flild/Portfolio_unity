using UnityEngine;

namespace Portfolio
{
    public class LevelController
    {
        private SceneController _scenes;
        public LevelController(SceneController scenes)
        {
            _scenes = scenes;
        }
        //логика переключение лвлов
        public void LoadNextLevel()
        {
            _scenes.LoadLevel(ScenesType.RagdollLevel);
        }

    }
}

