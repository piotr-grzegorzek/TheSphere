using TMPro;
using UnityEngine;

public class TextScore : MonoBehaviour
{
    private Player.Score _ps;

    void Start()
    {
        _ps = GameObject.FindWithTag(Tags.Player).GetComponent<Player.Score>();
        _ps.ChangeEvent += UpdateScoreText;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        GetComponent<TextMeshProUGUI>().text = $"Score: {_ps.Value}";
    }
}