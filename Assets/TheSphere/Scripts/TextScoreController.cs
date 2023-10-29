using TMPro;
using UnityEngine;

public class TextScoreController : MonoBehaviour
{
    private Player.ScoreController _psc;

    private TextMeshProUGUI _text;

    void Start()
    {
        _psc = GameObject.FindWithTag(Tag.Player).GetComponent<Player.ScoreController>();
        _text = GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
        _psc.ScoreChangeEvent += UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        _text.text = $"Score: {_psc.Score}";
    }
}