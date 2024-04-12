using System.Threading.Tasks;
using UnityEngine;

namespace Portfolio.RoomRagdoll
{
    //пока отказ от этого
    public class ObjectMoverAssistant
    {
        private float _movingTime = 2f;
        public async Task MoveDollAsync(Transform movingObject, Vector3 targetPosition)
        {
            float time = 0;
            Vector3 startPosition = movingObject.position;
            Vector3 endPosition = targetPosition;

            while (time < _movingTime)
            {
                movingObject.position = Vector3.Lerp(startPosition, endPosition, time);
                time += Time.deltaTime;
                await Task.Yield();
            }
            movingObject.position = endPosition;
        }
    }
}

