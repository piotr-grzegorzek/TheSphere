using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject _playerObject;

    private Vector3 _distance;

    void Start()
    {
        _playerObject = GameObject.Find(Constants.GameObject.Player);
        if (_playerObject == null)
        {
            Debug.LogWarning("Player game object not found");
        }
        else
        {
            _distance = _playerObject.transform.position - transform.position;
        }
    }

    void Update()
    {
        if (_playerObject != null)
        {
            gameObject.transform.position = _playerObject.transform.position - _distance;
        }
    }
}
