using System;
using UnityEngine;

namespace Player
{
    public class Score : MonoBehaviour
    {
        public event Action ChangeEvent;

        private int _score;

        public int Value => _score;

        public void ChangeBy(int amount)
        {
            _score += amount;
            ChangeEvent?.Invoke();
        }
    }
}