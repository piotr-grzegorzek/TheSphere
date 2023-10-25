using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public float Thrust = 5.0f;

        public float JumpForce = 100.0f;

        private Vector3 _axis;

        void Update()
        {
            // Input can be configured in Edit > Project Settings > Input Manager > Axes
            // According to docs they are framerate independent, so no time.deltaTime needed
            _axis.x = Input.GetAxis("Horizontal");
            _axis.y = (Input.GetKey(KeyCode.Space) && transform.position.y <= 0.5f) ? JumpForce : 0.0f;
            _axis.z = Input.GetAxis("Vertical");

            CheckFall();
        }

        void FixedUpdate()
        {
            GetComponent<Rigidbody>().AddForce(_axis * Thrust);
        }

        private void CheckFall()
        {
            if (transform.position.y < -10.0f)
            {
                transform.position = new Vector3(0.0f, 0.5f, 0.0f);
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                _axis = Vector3.zero;
            }
        }
    }
}