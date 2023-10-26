using UnityEngine;

namespace Player
{
    public class Position : MonoBehaviour
    {
        public Vector3 Start = new(0.0f, 0.5f, 0.0f);

        public float FallLimit = -10.0f;

        private bool _hasFallen = false;

        void Update()
        {
            _hasFallen = transform.position.y < FallLimit;
        }

        void FixedUpdate()
        {
            if (_hasFallen)
            {
                MoveTo(Start);
                _hasFallen = false;
            }
        }

        private void MoveTo(Vector3 position)
        {
            transform.position = position;
            Movement movement = GetComponent<Movement>();
            movement.Rb.velocity = Vector3.zero;
            movement.Axis = Vector3.zero;
        }
    }
}