using UnityEngine;
using Dictionaries;

public class Collectible : MonoBehaviour
{
    public float RotationSpeed = 1.0f;

    void Update()
    {
        // Time.deltaTime to make it framerate independent
        transform.Rotate(new Vector3(30, 20, 0) * RotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(TAG.PLAYER))
        {
            var psc = other.gameObject.GetComponent<PlayerScoreController>();
            psc.Score++;

            gameObject.SetActive(false);
            Debug.Log("Collected");
        }
    }
}