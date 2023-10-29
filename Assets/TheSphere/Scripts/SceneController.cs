using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int _totalPoints;

    private Player.ScoreController _psc;

    void Start()
    {
        _totalPoints = GameObject.FindGameObjectsWithTag(Tag.Point).Length;
        _psc = GameObject.FindWithTag(Tag.Player).GetComponent<Player.ScoreController>();
        _psc.ScoreChangeEvent += CheckScore;
    }

    private void CheckScore()
    {
        if (_psc.Score == _totalPoints)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}