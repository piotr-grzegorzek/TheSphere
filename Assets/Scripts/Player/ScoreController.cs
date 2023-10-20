using TMPro;
using UnityEngine;

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
                Debug.Log(_score);
                ScoreText.text = "Score: " + _score;
                if (WinConditionMet())
                {
                    Debug.Log("Won");
                    InfoText.text = "You won!";
                }
            }
        }

        void Start()
        {
            GameObject pointsObject = GameObject.Find(Constants.GameObject.Points);
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
}