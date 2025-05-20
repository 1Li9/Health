using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthTextUI : HealthUI
{
    private TextMeshProUGUI _text;

    private void Awake() =>
        _text = GetComponent<TextMeshProUGUI>();

    public override void ChangeValue(float value)
    {
        Health = value;
        float displayValue = Mathf.Round(Health);
        _text.text = $"{displayValue} / {MaxHealth}";
    }
}