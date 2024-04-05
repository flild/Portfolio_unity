using Portfolio.Interfaces;
using UnityEngine;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StonePhysic : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody _rb;
        private bool _hitted = false;
        private void Awake()
        {
            //Time.timeScale = 0.1f;
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision == null)
                return;
            if (_hitted)
                return;
            var hittedItem = collision.gameObject.GetComponentInParent<IHittable>();
            if (hittedItem != null)
            {
                var dir = collision.transform.position - transform.position; 
                hittedItem.TakeHit(_rb.velocity*_rb.mass, collision.contacts[0].point);
                _hitted = true;
                //высчитать направление от камня до объекта и применить это как силу
            }
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            if(_rb != null)
            {
                Gizmos.DrawLine(transform.position, _rb.velocity);
            }
        }
    }

}
