using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSliderUI : HealthUI
{
    protected Slider _slider;

    private void Awake() =>
        _slider = GetComponent<Slider>();

    public override void ChangeValue(float value)
    {
        float finalValue = value / MaxHealth;
        _slider.value = finalValue;
    }
}
