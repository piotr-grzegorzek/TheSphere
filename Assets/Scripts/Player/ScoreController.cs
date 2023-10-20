/* TODO: Decouple */
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class ScoreController : MonoBehaviour
    {
        public TMP_Text ScoreText;

        public TMP_Text InfoText;

        private int _totalPoints;

        private int _score;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreText.text = "Score: " + _score;
                if (WinConditionMet())
                {
                    WinRouter();
                }
            }
        }

        void Start()
        {
            GameObject pointsObject = GameObject.Find(Constants.GameObject.Points);
            if (pointsObject == null)
            {
                Debug.Log("Points game object not found, total points will not be calculated");
            }
            else
            {
                _totalPoints = pointsObject.transform.childCount;
                if (_totalPoints == 0)
                {
                    Debug.Log("No points found in the points game object");
                }
            }
        }

        private bool WinConditionMet()
        {
            return _score == _totalPoints;
        }

        private void WinRouter()
        {
            string sceneName = SceneManager.GetActiveScene().name;
            switch (sceneName)
            {
                case Constants.Scene.Level1:
                    _score = 0;
                    SceneManager.LoadScene(Constants.Scene.Level2);
                    break;
                case Constants.Scene.Level2:
                    InfoText.text = "You won!";
                    break;
                default:
                    Debug.Log($"Unknown scene name: {sceneName}, cannot load scene");
                    break;
            }
        }
    }
}