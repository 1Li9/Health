using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSmootheSliderUI : HealthSliderUI
{
    [SerializeField] private ValueAnimator _valueAnimator;
    [Range(0f, 0.01f)]
    [SerializeField] private float _animationStep;

    public override void ChangeValue(float value)
    {
        float finalValue = value / MaxHealth;
        float startValue = Health / MaxHealth;
        _valueAnimator.Animate((value) => _slider.value = value, startValue, finalValue);
        Health = value;
    }
}
