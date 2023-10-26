using UnityEngine;

public class Theme : MonoBehaviour
{
    void Awake()
    {
        // Don't destroy this object when loading new scenes
        DontDestroyOnLoad(gameObject);
    }
}