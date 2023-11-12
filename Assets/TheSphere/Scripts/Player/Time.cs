using System;
using UnityEngine;

namespace Player
{
    public class Time : MonoBehaviour
    {
        public SceneController SceneController;

        internal event Action TimeChangeEvent;

        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                TimeChangeEvent?.Invoke();
            }
        }

        void Start()
        {
            InvokeRepeating(nameof(Increment), 1f, 1f);
        }

        private void Increment()
        {
            Value++;
        }
    }
}
