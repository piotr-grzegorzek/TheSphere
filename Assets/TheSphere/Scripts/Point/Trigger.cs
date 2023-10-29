using UnityEngine;

namespace Point
{
    public class Trigger : MonoBehaviour
    {
        public float CollectionDelay = 1f;

        private Player.Score _ps;

        private Collider _collider;

        private MeshRenderer _meshRenderer;

        private AudioSource _audioSource;

        void Start()
        {
            _ps = GameObject.FindWithTag(Tags.Player).GetComponent<Player.Score>();
            _collider = GetComponent<Collider>();
            _meshRenderer = GetComponent<MeshRenderer>();
            _audioSource = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(Tags.Player))
            {
                _collider.enabled = false;
                _meshRenderer.enabled = false;
                _audioSource.Play();

                // scene change cuts audio, but coroutines, invoke are too slow
                _ps.Value++;
                Invoke(nameof(CollectDelayed), CollectionDelay);
            }
        }

        private void CollectDelayed()
        {
            gameObject.SetActive(false);
        }
    }
}