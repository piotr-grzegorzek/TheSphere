using UnityEngine;
using Player = Scripts.Player;

public class Collectible : MonoBehaviour
{
    public float RotationSpeed = 1.0f;

    void Update()
    {
        // Time.deltaTime to make it framerate independent
        transform.Rotate(RotationSpeed * Time.deltaTime * new Vector3(30, 20, 0));
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Player.Score>().ChangeBy(+1);
        // pickUpSound.Play();
        GetComponent<MeshRenderer>().enabled = false;
        gameObject.SetActive(false);
    }
}
