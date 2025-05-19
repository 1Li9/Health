using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHandler : ValueDisplay
{
    private Slider _slider;
    private float _value;

    public override float Value 
    { 
        get => _value; 

        set
        {
            if(value< 0f | value >1f) throw new ArgumentOutOfRangeException(nameof(Value));

            _value = value;
            _slider.value = value;
        }
    }

    private void Awake() =>
        _slider = GetComponent<Slider>();
}
