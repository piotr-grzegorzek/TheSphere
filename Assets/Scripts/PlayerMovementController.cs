using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody _rb;

    public float Thrust = 5.0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Input can be configured in Edit > Project Settings > Input Manager > Axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rb.AddForce(movement * Thrust);
    }
}