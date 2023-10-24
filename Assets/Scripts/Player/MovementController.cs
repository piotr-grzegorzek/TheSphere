using UnityEngine;

namespace Player
{
    public class MovementController : MonoBehaviour
    {
        public float Thrust = 5.0f;

        private Vector3 _movement;

        void Update()
        {
            // Input can be configured in Edit > Project Settings > Input Manager > Axes
            // According to docs they are framerate independent, so no time.deltaTime needed
            _movement.x = Input.GetAxis("Horizontal");
            _movement.z = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            GetComponent<Rigidbody>().AddForce(_movement * Thrust);
        }
    }
}