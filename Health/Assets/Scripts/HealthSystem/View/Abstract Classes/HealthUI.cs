using UnityEngine;

public abstract class HealthUI : MonoBehaviour
{
    [SerializeField] private HealthHandler _healthHandler;

    protected float MaxValue;
    protected float Value;

    private void OnEnable()
    {
        _healthHandler.ValueChanged += ChangeValue;
        _healthHandler.MaxValueChanged += SetMaxValue;
    }

    private void OnDisable()
    {
        _healthHandler.ValueChanged -= ChangeValue;
        _healthHandler.MaxValueChanged -= SetMaxValue;
    }

    public abstract void ChangeValue(float value);

    private void SetMaxValue(float value) =>
        MaxValue = value;
}
