using UnityEngine;

public class HealthButtonUI : MonoBehaviour
{
    [SerializeField] private HealthHandler _health;
    [Range(5f, 70f)]
    [SerializeField] private float _damage;
    [Range(5f, 70f)]
    [SerializeField] private float _healPoints;

    public void TakeDamage() =>
        _health.TakeDamage(_damage);

    public void Heal() =>
        _health.Heal(_healPoints);
}
