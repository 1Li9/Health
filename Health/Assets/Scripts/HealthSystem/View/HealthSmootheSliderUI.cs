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
        float finalValue = value / MaxValue;
        float startValue = Value / MaxValue;
        _valueAnimator.Animate((value) => Slider.value = value, startValue, finalValue);
        Value = value;
    }
}
