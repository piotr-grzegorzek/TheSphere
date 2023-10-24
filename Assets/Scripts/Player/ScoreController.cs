using System;
using UnityEngine;

namespace Player
{
    public class ScoreController : MonoBehaviour
    {
        public event Action ChangeEvent;

        private int _score;

        public int Score => _score;

        public void ChangeBy(int amount)
        {
            _score += amount;
            ChangeEvent?.Invoke();
        }
    }
}