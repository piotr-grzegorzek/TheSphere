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
        private Light _light;

        void Start()
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag(Tag.Player);
            _collider = GetComponent<Collider>();
            _meshRenderer = GetComponent<MeshRenderer>();
            _audioSource = GetComponent<AudioSource>();
            _light = GetComponent<Light>();
            _ps = playerObject.GetComponent<Player.Score>();
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tag.Player))
            {
                _collider.enabled = false;
                _meshRenderer.enabled = false;
                _light.enabled = false;
                _audioSource.Play();

                Invoke(nameof(Delayed), DelayedSeconds);
            }
        }

        private void Delayed()
        {
            gameObject.SetActive(false);
            _ps.Value++;
        }
    }
}
