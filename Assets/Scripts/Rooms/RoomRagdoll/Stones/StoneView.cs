using UnityEngine;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneView : MonoBehaviour
    {
        [SerializeField]
        private LineRenderer _lineRenderer;

        public void EnableLine()
        {
            _lineRenderer.enabled = true;
        }
        public void DisableLine()
        {
            _lineRenderer.enabled = false;
        }
        public void SetLine(Vector3[] points)
        {
            _lineRenderer.positionCount = points.Length;
            _lineRenderer.SetPositions(points);
        }
    }
}


