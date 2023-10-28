using System;
using UnityEngine;

namespace Player
{
    public class Score : MonoBehaviour
    {
        internal event Action ChangeEvent;

        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                ChangeEvent?.Invoke();
            }
        }
    }
}