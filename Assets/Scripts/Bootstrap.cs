
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Portfolio
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField]
        private Object _managersScene;
        private void Start()
        {
            SceneManager.LoadScene(_managersScene.name, LoadSceneMode.Additive);
        }
    }

}
