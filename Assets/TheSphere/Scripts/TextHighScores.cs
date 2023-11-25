using UnityEngine;
using TMPro;

public class TextHighScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs was set in format ($"Level{currentLevel}HighScore", currentScore);
        // Display each level's high score seperated by new line
        // get amount of high scores by checking if Level{level}HighScore key exists, if it doesnt then stop
        // for each level, get the high score and display it
        // key value is in seconds, display in hh:mm:ss format

        int level = 1;
        string highScores = "";
        while (PlayerPrefs.HasKey($"Level{level}HighScore"))
        {
            int highScore = PlayerPrefs.GetInt($"Level{level}HighScore");
            int hours = highScore / 3600;
            int minutes = highScore % 3600 / 60;
            int seconds = highScore % 60;
            highScores += $"Level {level}: {hours:00}:{minutes:00}:{seconds:00}\n";
            level++;
        }
        GetComponent<TextMeshProUGUI>().text = highScores;
    }
}
