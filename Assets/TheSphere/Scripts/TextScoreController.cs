using TMPro;
using UnityEngine;

public class TextScoreController : MonoBehaviour
{
    private Player.Score _ps;

    private TextMeshProUGUI _text;

    void Start()
    {
        _ps = GameObject.FindWithTag(Tag.Player).GetComponent<Player.Score>();
        _text = GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
        _ps.ScoreChangeEvent += UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        _text.text = $"Score: {_ps.Value}";
    }
}