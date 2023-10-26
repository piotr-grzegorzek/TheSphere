using UnityEngine;

namespace Player
{
    public class Position : MonoBehaviour
    {
        public Vector3 StartPosition = new(0.0f, 0.5f, 0.0f);

        public float FallLimit = -10.0f;

        private Movement _movement;

        private bool _hasFallen = false;

        void Start()
        {
            _movement = GetComponent<Movement>();
        }

        void Update()
        {
            _hasFallen = transform.position.y < FallLimit;
        }

        void FixedUpdate()
        {
            if (_hasFallen)
            {
                MoveTo(StartPosition);
                _hasFallen = false;
            }
        }

        private void MoveTo(Vector3 position)
        {
            transform.position = position;
            _movement.ResetInput();
        }
    }
}