using UnityEngine;
using Constant;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public float Thrust = 5f;
        public float JumpForce = 10f;
        public float GroundDistance = 1f;

        internal Rigidbody Rb;
        internal Vector3 Axis;

        private bool _wasInAir = false;

        internal void Reset()
        {
            Axis = Vector3.zero;
            if (Rb != null)
            {
                Rb.angularVelocity = Vector3.zero;
                Rb.velocity = Vector3.zero;
            }
        }

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

            if (IsGrounded() && _wasInAir)
            {
                MakeParticles();
            }

            _wasInAir = !IsGrounded();
        }
        void FixedUpdate()
        {
            Rb.AddForce(Axis * Thrust);
        }

        private bool IsGrounded()
        {
            LayerMask GroundLayer = LayerMask.GetMask(Layer.Ground);
            // Cast a ray downwards from the player's position
            return Physics.Raycast(transform.position, Vector3.down, out _, GroundDistance, GroundLayer);
        }
        private void MakeParticles()
        {
            GameObject[] particlesAll = GameObject.FindGameObjectsWithTag(Tag.JumpParticle);
            if (particlesAll.Length == 1)
            {
                GameObject particles = Instantiate(particlesAll[0], transform.position, Quaternion.identity);
                particles.GetComponent<ParticleSystem>().Play();
                GetComponent<AudioSource>().Play();
                Destroy(particles, 1f);
            }
        }
    }
}