using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float RotationSpeed = 1.0f;

    public Vector3 RotationAxis = new(30, 20, 0);

    public float CollectionDelay = 1f;

    private Player.Score _ps;

    private Collider _collider;

    private MeshRenderer _meshRenderer;

    private AudioSource _audioSource;

    void Start()
    {
        _collider = GetComponent<Collider>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Time.deltaTime to make it framerate independent
        transform.Rotate(RotationSpeed * Time.deltaTime * RotationAxis);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
        {
            _collider.enabled = false;
            _meshRenderer.enabled = false;
            _audioSource.Play();

            _ps = other.GetComponent<Player.Score>();
            Invoke(nameof(CollectDelayed), CollectionDelay);
        }
    }

    private void CollectDelayed()
    {
        _ps.ChangeBy(+1);
        gameObject.SetActive(false);
    }
}