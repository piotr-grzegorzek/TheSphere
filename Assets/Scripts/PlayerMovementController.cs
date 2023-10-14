using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody _rb;

    private float _moveX;

    private float _moveZ;

    public float Speed = 5.0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Input can be configured in Edit > Project Settings > Input Manager > Axes
        // According to docs they are framerate independent, so no time.deltaTime needed
        _moveX = Input.GetAxis("Horizontal");
        _moveZ = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_moveX, 0.0f, _moveZ);
        _rb.AddForce(movement * Speed);
    }
}