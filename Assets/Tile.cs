using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public int value;
    public TextMeshProUGUI valueText;

    public void SetValue(int newValue)
    {
        value = newValue;
        valueText.text = value.ToString();
    }
}