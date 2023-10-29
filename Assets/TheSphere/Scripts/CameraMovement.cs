using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _player;

    private Vector3 _offset;

    void Start()
    {
        _player = GameObject.FindWithTag(Tags.Player).transform;
        _offset = transform.position - _player.position;
    }

    void LateUpdate()
    {
        transform.position = _player.position + _offset;
    }
}