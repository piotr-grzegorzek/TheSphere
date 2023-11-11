using UnityEngine;

namespace Point
{
    public class Movement : MonoBehaviour
    {
        public float RotationSpeed = 1.0f;
        public Vector3 RotationAxis = new Vector3(30, 20, 0);

        void Update()
        {
            // Time.deltaTime to make it framerate independent
            transform.Rotate(RotationSpeed * Time.deltaTime * RotationAxis);
        }
    }
}
