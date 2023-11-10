using UnityEngine;

public class KillBoxTrigger : MonoBehaviour
{
    public Vector3 StartPosition = new(0.0f, 0.5f, 0.0f);

    private Player.Movement _pm;

    void Start()
    {
        _pm = GameObject.FindWithTag(Tag.Player).GetComponent<Player.Movement>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag.Player))
        {
            other.transform.position = StartPosition;
            _pm.Reset();
        }
    }
}