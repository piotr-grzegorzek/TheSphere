using UnityEngine;
using Constant;

namespace Point
{
    public class Trigger : MonoBehaviour
    {
        public float DelayedSeconds = 1f;

        private Player.Score _ps;
        private Collider _collider;
        private MeshRenderer _meshRenderer;
        private AudioSource _audioSource;

        void Start()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag(Tag.Player);
            _ps = playerObject.GetComponent<Player.Score>();

            _collider = GetComponent<Collider>();
            _meshRenderer = GetComponent<MeshRenderer>();
            _audioSource = GetComponent<AudioSource>();
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tag.Player))
            {
                _collider.enabled = false;
                _meshRenderer.enabled = false;
                _audioSource.Play();
                _ps.Value++;

                Invoke(nameof(Delayed), DelayedSeconds);
            }
        }

        private void Delayed()
        {
            gameObject.SetActive(false);
        }
    }
}
