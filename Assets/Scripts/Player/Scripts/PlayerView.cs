using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : MonoBehaviour
    {
        public Rigidbody Rigidbody { get; private set; }
        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

    }
}


