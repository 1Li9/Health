using System;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private float _startValue;

    private Health _health;

    public event Action<float> ValueChanged;
    public event Action<float> MaxValueChanged;

    private void Awake()
    {
        _health = new Health();
    }

    private void OnEnable()
    {
        _health.ValueChanged += (value) => ValueChanged?.Invoke(value);
        _health.MaxValueChanged += (value) => MaxValueChanged?.Invoke(value);
    }

    private void OnDisable()
    {
        _health.ValueChanged -= (value) => ValueChanged?.Invoke(value);
        _health.MaxValueChanged -= (value) => MaxValueChanged?.Invoke(value);
    }

    private void Start()
    {
        _health.SetValue(_startValue);
    }

    public void TakeDamage(float damage) =>
        _health.TakeDamage(damage);

    public void Increase(float healPoints) =>
        _health.Increase(healPoints);
}