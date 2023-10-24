using UnityEngine;

namespace Scripts.Camera
{
    public class Movement : MonoBehaviour
    {
        private Transform _player;

        private Vector3 _offset;

        void Start()
        {
            _player = GameObject.FindWithTag(Constants.Tags.Player).transform;
            _offset = _player.position - transform.position;
        }

        void Update()
        {
            transform.position = _player.position - _offset;
        }
    }
}