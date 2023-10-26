using TMPro;
using UnityEngine;

public class TextScore : MonoBehaviour
{
    private Player.Score _ps;

    private TextMeshProUGUI _text;

    void Start()
    {
        _ps = GameObject.FindWithTag(Tags.Player).GetComponent<Player.Score>();
        _text = GetComponent<TextMeshProUGUI>();
        _ps.ChangeEvent += UpdateScoreText;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        _text.text = $"Score: {_ps.Value}";
    }
}