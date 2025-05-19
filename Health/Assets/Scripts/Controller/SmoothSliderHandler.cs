using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSliderHandler : ValueDisplay
{
    [SerializeField] private ValueAnimator _valueAnimator;

    private Coroutine _coroutine;

    private float _value;
    private Slider _slider;

    public override float Value
    {
        get => _value;

        set
        {
            if (value < 0f | value > 1f) 
                throw new ArgumentOutOfRangeException(nameof(Value));

            _valueAnimator.Animate((value) => _slider.value = value, _value, value);
            _value= value;
        }
    }

    private void Awake() =>
        _slider = GetComponent<Slider>();
}
