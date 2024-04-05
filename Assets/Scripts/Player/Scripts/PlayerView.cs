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
        [SerializeField]
        private float _maxRayCastDistance;
        public event Action<RaycastHit> SmallRaycastEvent;
        public event Action<RaycastHit> BigRaycastEvent;
        public event Action FixedUpdateEvent;
        public void Initialize(PlayerAnimation anim)
        {
            AnimationController = anim;
        }
        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2,0));
            if (Physics.Raycast(ray, out RaycastHit hit, _maxRayCastDistance))
            {
                SmallRaycastEvent?.Invoke(hit);
            }
            else
            {
                SmallRaycastEvent?.Invoke(hit);
            }

            if (Physics.Raycast(ray, out RaycastHit hitMax))
            {
                BigRaycastEvent?.Invoke(hitMax);
            }
            else
            {
                BigRaycastEvent?.Invoke(hitMax);
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


