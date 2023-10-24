using UnityEngine;

namespace Scripts.Player
{
    public class Movement : MonoBehaviour
    {
        public float Thrust = 5.0f;

        private Vector3 _axis;

        void Update()
        {
            // Input can be configured in Edit > Project Settings > Input Manager > Axes
            // According to docs they are framerate independent, so no time.deltaTime needed
            _axis.x = Input.GetAxis("Horizontal");
            _axis.z = Input.GetAxis("Vertical");
        }

        void FixedUpdate()
        {
            GetComponent<Rigidbody>().AddForce(_axis * Thrust);
        }
    }
}