using UnityEngine;

namespace Portfolio.RoomRagdoll.Stones
{
    public class StoneThrowTrajectoryCalculator
    {
        private int _pointsMasSize = 100;
        private float _timeStep = 0.01f;
        public Vector3[] CalcuteTrajectory(Vector3 StartPos, Vector3 speed)
        {
            Vector3[] points = new Vector3[_pointsMasSize];
            for(int i = 0; i<points.Length; i++)
            {
                float time = i * _timeStep;

                points[i] = StartPos + speed * time + Physics.gravity * time * time / 2f;
            }
            return points;
        }
        public double TimeToTarget(double initialVelocity, float angle)
        {
            const float PI = 3.14159f;
            const float gravity = 9.81f;
            float angleRadians = angle * PI / 180f; // ѕереводим угол из градусов в радианы

            // –ассчитываем врем€ полета по формуле
            double time = 2 * initialVelocity * Mathf.Sin(angleRadians) / gravity;

            return time;
        }

    }
}

