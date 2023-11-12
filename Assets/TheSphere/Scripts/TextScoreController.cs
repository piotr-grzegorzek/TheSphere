using TMPro;
using UnityEngine;
using Constant;

public class TextScoreController : MonoBehaviour
{
    private Player.Score _ps;
    private TextMeshProUGUI _text;

    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag(Tag.Player);
        _ps = playerObject.GetComponent<Player.Score>();
        _text = GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
        _ps.ScoreChangeEvent += UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        _text.text = $"Score: {_ps.Value}";
    }
}
