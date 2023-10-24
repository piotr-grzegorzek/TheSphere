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
                ScoreText.text = $"Score: {_score}/{_totalPoints}";
                if (LevelUpConditionMet())
                {
                    LevelUp();
                }
            }
        }

        void Start()
        {
            GameObject points = GameObject.Find(Constants.GameObject.Points);
            if (points == null)
            {
                Debug.Log("Points game object not found, total points will not be calculated");
            }
            else
            {
                _totalPoints = points.transform.childCount;
                if (_totalPoints == 0)
                {
                    Debug.Log("No points found in the points game object");
                }
            }
            ScoreText.text = $"Score: {_score}/{_totalPoints}";
        }

        private bool LevelUpConditionMet()
        {
            return _score == _totalPoints;
        }

        private void LevelUp()
        {
            int sceneID = SceneManager.GetActiveScene().buildIndex;
            switch (sceneID)
            {
                case 1:
                    SceneManager.LoadScene(2);
                    break;
                case 2:
                    InfoText.text = "You won!";
                    break;
                default:
                    Debug.Log($"LevelUp() called in scene {sceneID} which is not supported");
                    break;
            }
        }
    }
}