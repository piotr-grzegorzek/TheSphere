using UnityEngine;

namespace Point
{
    public class Movement : MonoBehaviour
    {
        public float RotationSpeed = 50f;
        public float MovementSpeed = 6f;
        public float MovementDistance = 0.15f;

        private Vector3 _startPosition;

        void Start()
        {
            _startPosition = transform.position;
        }
        void Update()
        {
            transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);
            transform.position = _startPosition + Mathf.Sin(Time.time * MovementSpeed) * MovementDistance * Vector3.up;
        }
    }
}