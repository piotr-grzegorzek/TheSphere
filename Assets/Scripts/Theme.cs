using UnityEngine;

public class Theme : MonoBehaviour
{
    void Awake()
    {
        // This is a singleton pattern. It ensures that only one instance of this object exists at any given time

        // Find the object with the "Music" tag
        var obj = GameObject.FindGameObjectWithTag("Music");

        // If there is already an object with the "Music" tag, destroy current object
        if (obj != null && obj != gameObject)
        {
            Destroy(gameObject);
        }

        // If there is no object with the "Music" tag, don't destroy this object
        DontDestroyOnLoad(gameObject);
    }
}