using System;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHandler : ValueDisplay
{
    private TextMeshProUGUI _text;
    private float _value;

    public override float MaxValue => base.MaxValue;
    public override float Value 
    {
        get => _value;
        
        set
        {
            if (value < 0f | value > 1f) throw new ArgumentOutOfRangeException(nameof(Value));

            _value = value;

            float healthPoints = _value * MaxValue;
            healthPoints = Mathf.Round(healthPoints);

            _text.text = $"{healthPoints} / {MaxValue}";
        }
    }

    private void Awake() =>
        _text = GetComponent<TextMeshProUGUI>();
}
