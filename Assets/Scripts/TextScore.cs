using TMPro;
using UnityEngine;
using Constants = Scripts.Constants;
using Player = Scripts.Player;

public class TextScore : MonoBehaviour
{
    private Player.Score _ps;

    void Start()
    {
        var player = GameObject.FindWithTag(Constants.Tags.Player);
        _ps = player.GetComponent<Player.Score>();
        _ps.ChangeEvent += UpdateScoreText;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        GetComponent<TextMeshProUGUI>().text = $"Score: {_ps.Get()}";
    }
}
