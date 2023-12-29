using UnityEngine;
using Portfolio.PlayerSpace;
using Zenject;


namespace Portfolio
{
    public class GameManager : MonoInstaller
    {
        [SerializeField]
        private Player _player;

        public override void InstallBindings()
        {
            Container.BindInstance(_player).AsSingle();

        }

        private void OnValidate()
        {
            if(_player == null)
                _player = FindObjectOfType<Player>();
        }
    }
}

