using UnityEngine;
using Constant;

public class KillBoxTrigger : MonoBehaviour
{
    public Vector3 StartPosition = new Vector3(0.0f, 0.5f, 0.0f);

    private Player.Movement _pm;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag(Tag.Player);
        _pm = playerObject.GetComponent<Player.Movement>();
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
