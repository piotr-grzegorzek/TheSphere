using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Transform _points;

    private Player.Score _ps;

    void Start()
    {
        _points = GameObject.FindGameObjectWithTag(Tags.Points).transform;
        _ps = GameObject.FindWithTag(Tags.Player).GetComponent<Player.Score>();
        _ps.ChangeEvent += CheckScore;
    }

    private void CheckScore()
    {
        if (_ps.Value == _points.childCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}