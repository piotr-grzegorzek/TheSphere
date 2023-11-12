using TMPro;
using UnityEngine;
using Constant;

public class TextTimeController : MonoBehaviour
{
    private Player.Time _pt;
    private TextMeshProUGUI _text;

    void Start()
    {
        GameObject playerObject = GameObject.FindWithTag(Tag.Player);
        _pt = playerObject.GetComponent<Player.Time>();
        _text = GetComponent<TextMeshProUGUI>();
        UpdateTimeText();
        _pt.TimeChangeEvent += UpdateTimeText;
    }

    private void UpdateTimeText()
    {
        _text.text = $"Time: {_pt.Value}";
    }
}
