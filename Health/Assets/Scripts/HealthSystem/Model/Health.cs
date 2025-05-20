using System;

public class Health
{
    private float _value;
    private float _maxValue;

    public event Action<float> ValueChanged;
    public event Action<float> MaxValueChanged;

    public float Value
    {
        get => _value;

        private set
        {
            _value = value;
            ValueChanged?.Invoke(_value);
        }
    }

    public float MaxValue
    {
        get => _maxValue;

        private set
        {
            _maxValue = value;
            MaxValueChanged?.Invoke(_maxValue);
        }
    }

    public bool IsAlive { get; private set; } = true;

    public void SetValue(float value)
    {
        MaxValue = value;
        Value = MaxValue;
    }

    public void TakeDamage(float damage)
    {
        if (Value - damage <= 0)
        {
            Value = 0;
            IsAlive = false;

            return;
        }

        Value -= damage;
    }

    public void Increase(float healPoints)
    {
        if (Value + healPoints >= MaxValue)
        {
            Value = MaxValue;

            return;
        }

        Value += healPoints;
    }
}