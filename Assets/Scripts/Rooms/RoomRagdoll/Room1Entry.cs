using Portfolio.PlayerSpace;
using Portfolio.RoomRagdoll.Dolls;
using UnityEngine;
using Zenject;

namespace Portfolio.RoomRagdoll
{
    public class RoomRagdollEntry : MonoBehaviour
    {
        [SerializeField]
        private Doll _doll;
        [SerializeField]
        private float _force;
        [Inject]
        private GameManager _gameManager;
        private void Start()
        {
            Debug.Log(_gameManager);
        }
        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                
                if(Physics.Raycast(ray, out RaycastHit hit))
                {
                    Doll doll = hit.collider.GetComponentInParent<Doll>();
                    if(doll != null)
                    {
                        Vector3 forceDirection = (hit.point - Camera.main.transform.position).normalized;
                        forceDirection.y = 0;

                        doll.TakeHit(forceDirection * _force, hit.point);
                    }
                }
            }
        }


    }
}

