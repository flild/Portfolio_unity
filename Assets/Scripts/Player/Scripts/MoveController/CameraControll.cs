using UnityEngine;

namespace Portfolio.PlayerSpace
{
    public class CameraControll
    {
        private Camera _camera;
        private float rotationY = 0f;
        private float minimumX = -60f;
        private float maximumX = 60f;
        private float YsensCoef = 0.3f;
        private float _mouseSense;
        public CameraControll(Camera camera, float mouseSense)
        {
            if (camera == null)
                Debug.LogError("Camera in Camera controll is null");
            _camera = camera;
            _mouseSense = mouseSense;
        }

        public void Rotate(Vector2 dir)
        {
            rotationY -= dir.y * _mouseSense * YsensCoef;
            rotationY = Mathf.Clamp(rotationY, minimumX, maximumX);
            _camera.transform.localRotation = Quaternion.Euler(rotationY, 0f, 0f);
        }
    }
}

