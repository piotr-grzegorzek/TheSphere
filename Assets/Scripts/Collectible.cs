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
            other.gameObject.GetComponent<Player.Score>().ChangeBy(+1);

            GetComponent<AudioSource>().Play();
            GetComponent<MeshRenderer>().enabled = false;
            // Delay the set active to let the sound play
            Invoke(nameof(DelayedCollect), 2.0f);
        }
    }

    private void DelayedCollect()
    {
        gameObject.SetActive(false);
    }
}