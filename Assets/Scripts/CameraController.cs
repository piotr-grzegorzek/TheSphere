using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject _player;

    private Vector3 _distance;

    void Start()
    {
        _player = GameObject.Find(Constants.GameObject.Player);
        if (_player == null)
        {
            Debug.Log("Player game object not found, distance will not be calculated");
        }
        else
        {
            _distance = _player.transform.position - transform.position;
        }
    }

    void Update()
    {
        if (_player != null)
        {
            gameObject.transform.position = _player.transform.position - _distance;
        }
    }
}
