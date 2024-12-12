using UnityEngine;

namespace GC.Code.Gameplay.CameraSystem
{
    public class CameraController : MonoBehaviour
    {
        public void Init()
        {

        }

        public void SetFocusPoint(Transform newPoint)
        {

        }

        public void SetInput()
        {

        }

        public void EnableInput()
        {

        }

        public void DisableInput()
        {

        }

        private void RotateCamera()
        {

        }

        private float ClampAngle(float angle, float min, float max)
        {
            if (angle < -360F) angle += 360F;
            if (angle > 360F) angle -= 360F;
            return Mathf.Clamp(angle, min, max);
        }
    }
}

