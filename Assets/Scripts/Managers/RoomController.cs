using UnityEngine;

namespace Portfolio
{
    public class RoomController
    {
        private SceneController _scenes;
        public RoomController(SceneController scenes)
        {
            _scenes = scenes;
        }
        //������ ������������ �����
        public void LoadNextRoom()
        {
            _scenes.LoadLevel(ScenesType.RagdollLevel);
        }

    }
}

