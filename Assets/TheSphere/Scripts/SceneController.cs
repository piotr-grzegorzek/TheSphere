using UnityEngine;
using UnityEngine.SceneManagement;
using Constant;

public class SceneController : MonoBehaviour
{
    private int _totalPoints;
    private Player.Score _ps;

    void Start()
    {
        GameObject[] pointObjects = GameObject.FindGameObjectsWithTag(Tag.Point);
        _totalPoints = pointObjects.Length;

        GameObject player = GameObject.FindGameObjectWithTag(Tag.Player);
        _ps = player.GetComponent<Player.Score>();
        _ps.ScoreChangeEvent += CheckScore;
    }

    private void CheckScore()
    {
        if (_totalPoints != 0 && _ps.Value == _totalPoints)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
