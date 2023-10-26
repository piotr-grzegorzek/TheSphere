using System;
using UnityEngine;

namespace Player
{
    public class Score : MonoBehaviour
    {
        internal int Value { get; private set; }

        internal event Action ChangeEvent;

        internal void ChangeBy(int amount)
        {
            Value += amount;
            ChangeEvent?.Invoke();
        }
    }
}