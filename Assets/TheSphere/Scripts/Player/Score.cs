using System;
using UnityEngine;

namespace Player
{
    public class Score : MonoBehaviour
    {
        internal event Action ScoreChangeEvent;

        private int _value;

        public int Value
        {
            get => _value;
            internal set
            {
                _value = value;
                ScoreChangeEvent?.Invoke();
            }
        }
    }
}
