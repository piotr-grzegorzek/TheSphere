using UnityEngine;

public class Theme : MonoBehaviour
{
    void Awake()
    {
        // This is a singleton pattern. It ensures that only one instance of this object exists at any given time

        // Find all objects with the "Music" tag
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        // If there is more than one, destroy this object
        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }

        // If there is only one, dont destroy this object
        DontDestroyOnLoad(gameObject);
    }
}
