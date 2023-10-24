using System;
using UnityEngine;

namespace Scripts.Player
{
    public class Score : MonoBehaviour
    {
        public event Action ChangeEvent;

        private int _score;

        public int Get()
        {
            return _score;
        }

        public void ChangeBy(int amount)
        {
            _score += amount;
            ChangeEvent?.Invoke();
        }
    }
}