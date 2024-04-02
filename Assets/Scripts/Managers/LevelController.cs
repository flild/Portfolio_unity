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
        //������ ������������ �����
        public void LoadNextLevel()
        {
            _scenes.LoadLevel(ScenesType.RagdollLevel);
        }

    }
}

