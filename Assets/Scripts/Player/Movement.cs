using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public float Thrust = 5f;

        public float JumpForce = 100f;

        internal Rigidbody Rb;

        internal Vector3 Axis;

        void Start()
        {
            // Cache for performance
            Rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            // Input can be configured in Edit > Project Settings > Input Manager > Axes
            // According to docs they are framerate independent, so no time.deltaTime needed
            Axis.x = Input.GetAxis("Horizontal");
            Axis.y = (Input.GetKey(KeyCode.Space) && transform.position.y <= 0.5f) ? JumpForce : 0f;
            Axis.z = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            Rb.AddForce(Axis * Thrust);
        }

        internal void ResetInput()
        {
            Rb.velocity = Vector3.zero;
            Axis = Vector3.zero;
        }
    }
}