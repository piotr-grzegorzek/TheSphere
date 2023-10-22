using UnityEngine;

namespace Player
{
    public class MovementController : MonoBehaviour
    {
        public float Thrust = 5.0f;

        private Rigidbody _rb;

        private float _moveX;

        private float _moveZ;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            // Input can be configured in Edit > Project Settings > Input Manager > Axes
            // According to docs they are framerate independent, so no time.deltaTime needed
            _moveX = Input.GetAxis("Horizontal");
            _moveZ = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            Vector3 movement = new(_moveX, 0.0f, _moveZ);
            _rb.AddForce(movement * Thrust);
        }
    }
}