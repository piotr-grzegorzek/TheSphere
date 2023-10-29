using UnityEngine;

public class KillBox : MonoBehaviour
{
    public Vector3 StartPosition = new(0.0f, 0.5f, 0.0f);

    private Player.MovementController _pmc;

    void Start()
    {
        _pmc = GameObject.FindWithTag(Tag.Player).GetComponent<Player.MovementController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag.Player))
        {
            other.transform.position = StartPosition;
            _pmc.Reset();
        }
    }
}