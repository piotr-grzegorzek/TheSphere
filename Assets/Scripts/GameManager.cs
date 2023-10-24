using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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
        if (_ps.Get() == _points.childCount)
        {
            int sceneID = SceneManager.GetActiveScene().buildIndex;
            switch (sceneID)
            {
                case 1:
                    SceneManager.LoadScene(2);
                    break;
                case 2:
                    TextMeshProUGUI textInfo = GameObject.FindWithTag(Tags.TextInfo).GetComponent<TextMeshProUGUI>();
                    textInfo.text = "You won!";
                    break;
                default:
                    Debug.Log($"LevelUp() called in scene {sceneID} which is not supported");
                    break;
            }
        }
    }
}