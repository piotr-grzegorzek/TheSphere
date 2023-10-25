using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float RotationSpeed = 1.0f;

    public Vector3 RotationAxis = new(30, 20, 0);

    void Update()
    {
        // Time.deltaTime to make it framerate independent
        transform.Rotate(RotationSpeed * Time.deltaTime * RotationAxis);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
        {
            GetComponent<Collider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<AudioSource>().Play();

            // Delay the set active to let the sound play after normal collection
            Invoke(nameof(DelayedCollect), 2.0f);

            // Scene might change and sound might be cut off
            // Coroutines could be used but they are too slow (probably because of the Player.Score component)
            other.gameObject.GetComponent<Player.Score>().ChangeBy(+1);
        }
    }

    private void DelayedCollect()
    {
        gameObject.SetActive(false);
    }
}