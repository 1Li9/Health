using UnityEngine;

public abstract class HealthUI : MonoBehaviour
{
    [SerializeField] private HealthHandler _healthHandler;

    protected float MaxHealth;
    protected float Health;

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

    public abstract void ChangeValue(float value);

    private void SetMaxValue(float value) =>
        MaxHealth = value;
}
