using AYellowpaper.SerializedCollections;
using Portfolio.Extensions;
using System;
using UnityEngine;

namespace Portfolio.PlayerSpace
{
    [RequireComponent(typeof(Rigidbody),typeof(Animator))]
    public class PlayerView : MonoBehaviour
    {
        public PlayerAnimation AnimationController { get; private set; }
        [SerializeField]
        private SerializedDictionary<PlayerBodyParts, Transform> _BodyPartMap;
        public event Action<RaycastHit> RaycastEvent;
        public event Action FixedUpdateEvent;
        public void Initialize(PlayerAnimation anim)
        {
            AnimationController = anim;
        }
        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2,0));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                RaycastEvent?.Invoke(hit);
            }
        }
        private void FixedUpdate()
        {
            FixedUpdateEvent?.Invoke();
        }
        public Transform GetBodyPart(PlayerBodyParts type)
        {
            return _BodyPartMap[type];
        }

    }
}


