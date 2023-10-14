using UnityEngine;

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
        if (other.CompareTag(Dictionaries.Tag.Player))
        {
            var psc = other.gameObject.GetComponent<PlayerScoreController>();
            psc.Score++;

            gameObject.SetActive(false);
            Debug.Log("Collected");
        }
    }
}
