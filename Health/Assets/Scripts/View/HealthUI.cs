using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private HealthHandler _healthHandler;
    [SerializeField] private ValueDisplay _valueDisplay;

    private float _maxHealth;

    private void OnEnable()
    {
        _healthHandler.Health.OnHealthPointsChanged += ChangeValue;
        _healthHandler.Health.OnMaxHealthPointsChanged += SetMaxValue;
    }

    private void OnDisable()
    {
        _healthHandler.Health.OnHealthPointsChanged -= ChangeValue;
        _healthHandler.Health.OnMaxHealthPointsChanged -= SetMaxValue;
    }

    public void ChangeValue(float value)
    {
        value /= _maxHealth;
        _valueDisplay.Value = value;
    }

    private void SetMaxValue(float value)
    {
        _maxHealth = value;
        _valueDisplay.MaxValue = value;
    }
}
