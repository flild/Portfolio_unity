using UnityEngine;

namespace Portfolio.Interfaces
{
    public interface IHittable
    {
        public void TakeHit(Vector3 force, Vector3 hitPoint);
    }

}
