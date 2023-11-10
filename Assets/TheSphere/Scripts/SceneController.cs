using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int _totalPoints;

    private Player.Score _ps;

    void Start()
    {
        _totalPoints = GameObject.FindGameObjectsWithTag(Tag.Point).Length;
        _ps = GameObject.FindWithTag(Tag.Player).GetComponent<Player.Score>();
        _ps.ScoreChangeEvent += CheckScore;
    }

    private void CheckScore()
    {
        if (_ps.Value == _totalPoints)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}