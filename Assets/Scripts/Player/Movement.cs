using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public float Thrust = 5f;

        public float JumpForce = 10f;

        public float ColliderDistance = 1f;

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
            Axis.y = (Input.GetKey(KeyCode.Space) && IsGrounded()) ? JumpForce : 0f;
            Axis.z = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            Rb.AddForce(Axis * Thrust);
        }

        internal void Reset()
        {
            Axis = Vector3.zero;
            Rb.angularVelocity = Vector3.zero;
            Rb.velocity = Vector3.zero;
        }

        private bool IsGrounded()
        {
            LayerMask GroundLayer = LayerMask.GetMask(Tags.Collider);
            // Cast a ray downwards from the player's position
            if (Physics.Raycast(transform.position, Vector3.down, out _, ColliderDistance, GroundLayer))
            {
                // If the ray hits the ground, the player is grounded
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}