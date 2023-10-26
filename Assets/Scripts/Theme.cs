using UnityEngine;

public class Theme : MonoBehaviour
{
    void Awake()
    {
        // This is a singleton pattern. It ensures that only one instance of this object exists at any given time
        // Destroy this object if another object with the "Music" tag already exists
        var obj = GameObject.FindGameObjectWithTag("Music");
        if (obj != null && obj != gameObject)
        {
            Destroy(gameObject);
        }

        // Don't destroy this object when loading new scenes
        DontDestroyOnLoad(gameObject);
    }
}