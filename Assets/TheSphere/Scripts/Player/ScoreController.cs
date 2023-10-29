using System;
using UnityEngine;

namespace Player
{
    public class ScoreController : MonoBehaviour
    {
        internal event Action ScoreChangeEvent;

        private int _score;

        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreChangeEvent?.Invoke();
            }
        }
    }
}