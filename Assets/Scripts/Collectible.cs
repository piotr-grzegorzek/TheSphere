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
        other.gameObject.GetComponent<Player.Score>().ChangeBy(+1);
        // pickUpSound.Play();
        GetComponent<MeshRenderer>().enabled = false;
        gameObject.SetActive(false);
    }
}
