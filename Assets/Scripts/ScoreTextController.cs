using TMPro;
using UnityEngine;

public class ScoreTextController : MonoBehaviour
{
    private Player.ScoreController _psc;

    void Start()
    {
        var player = GameObject.FindWithTag(Constants.Tags.Player);
        _psc = player.GetComponent<Player.ScoreController>();
        _psc.ChangeEvent += UpdateScoreText;
    }

    private void UpdateScoreText()
    {
        GetComponent<TextMeshProUGUI>().text = $"Score: {_psc.Score}";
    }
}
