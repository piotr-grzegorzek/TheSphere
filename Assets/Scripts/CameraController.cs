using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _player;

    private Vector3 _distance;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag(Constants.Tags.Player).transform;
        _distance = _player.position - transform.position;
    }

    void Update()
    {
        gameObject.transform.position = _player.position - _distance;
    }
}
