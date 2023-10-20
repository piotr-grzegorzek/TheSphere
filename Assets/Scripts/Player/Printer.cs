using System.Collections;
using System.Collections.Generic;
using Player;
using TMPro;
using UnityEngine;

public class Printer : MonoBehaviour
{
    public TMP_Text ScoreText;

    void Update()
    {
        var scoreController = gameObject.GetComponent<ScoreController>();
        ScoreText.text = "Score: " + scoreController.Score;
    }
}
