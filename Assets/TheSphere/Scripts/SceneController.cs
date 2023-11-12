using UnityEngine;
using UnityEngine.SceneManagement;
using Constant;

public class SceneController : MonoBehaviour
{
    private int _totalPoints;
    private Player.Score _ps;
    private Player.Time _pt;

    void Start()
    {
        GameObject[] pointObjects = GameObject.FindGameObjectsWithTag(Tag.Point);
        _totalPoints = pointObjects.Length;

        GameObject player = GameObject.FindGameObjectWithTag(Tag.Player);
        _ps = player.GetComponent<Player.Score>();
        _ps.ScoreChangeEvent += CheckScore;

        _pt = player.GetComponent<Player.Time>();
    }

    private void CheckScore()
    {
        if (_totalPoints != 0 && _ps.Value == _totalPoints)
        {
            HandleHighScore();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void HandleHighScore()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        int currentScore = _pt.Value;
        int highScore = PlayerPrefs.GetInt($"Level{currentLevel}HighScore", 0);

        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt($"Level{currentLevel}HighScore", currentScore);
        }
    }
}
