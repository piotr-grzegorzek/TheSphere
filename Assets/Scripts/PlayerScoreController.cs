using UnityEngine;

public class PlayerScoreController : MonoBehaviour
{
    private int _totalPoints;

    private int _score;

    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            Debug.Log(_score);
            if (WinConditionMet())
            {
                Debug.Log("Won");
            }
        }
    }

    void Start()
    {
        GameObject pointsObject = GameObject.Find(Dictionaries.GameObject.Points);
        if (pointsObject == null)
        {
            Debug.LogWarning("Points game object not found");
        }
        else
        {
            _totalPoints = pointsObject.transform.childCount;
            if (_totalPoints == 0)
            {
                Debug.LogWarning("No points found in the points game object");
            }
        }
    }

    private bool WinConditionMet()
    {
        return _score == _totalPoints;
    }
}
