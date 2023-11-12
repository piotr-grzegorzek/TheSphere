using UnityEngine;
using Constant;

public class CameraMovement : MonoBehaviour
{
    private Transform _player;
    private Vector3 _offset;

    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag(Tag.Player);
        _player = playerObject.transform;
        _offset = transform.position - _player.position;
    }
    void LateUpdate()
    {
        transform.position = _player.position + _offset;
    }
}
