using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Portfolio
{
    [CreateAssetMenu(fileName = "SceneManager", menuName = "ScriptableObject/Managers/Scene Manager")]
    public class SceneController: ScriptableObject
    {
        [SerializeField]
        private SerializedDictionary<ScenesType, Object> _scenesMap; 


        public void LoadLevel(ScenesType type)
        {
            SceneManager.UnloadSceneAsync(0);
            SceneManager.LoadSceneAsync(_scenesMap[type].name, LoadSceneMode.Additive);
        }
        public void UnloadScene(ScenesType type)
        {
            SceneManager.UnloadSceneAsync(_scenesMap[type].name);
        }
    }

    public enum ScenesType
    {
        RagdollLavel,
        StartMenu
    }
}

