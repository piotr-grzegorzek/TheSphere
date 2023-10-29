using UnityEngine;

namespace Point
{
    public class TriggerController : MonoBehaviour
    {
        public float DelayedSeconds = 1f;

        private Player.ScoreController _psc;

        private Collider _collider;

        private MeshRenderer _meshRenderer;

        private AudioSource _audioSource;

        void Start()
        {
            _psc = GameObject.FindWithTag(Tag.Player).GetComponent<Player.ScoreController>();
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

                // scene change cuts audio, but coroutines, invoke are too slow
                _psc.Score++;
                Invoke(nameof(Delayed), DelayedSeconds);
            }
        }

        private void Delayed()
        {
            gameObject.SetActive(false);
        }
    }
}