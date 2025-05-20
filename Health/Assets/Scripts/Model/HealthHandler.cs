using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private float _startHealthPoints;

    public Health Health { get; private set; }

    private void Awake() =>
        Health = new Health();

    private void Start() =>
        Health.SetHealthPoints(_startHealthPoints);

    public void TakeDamage(float damage) =>
        Health.TakeDamage(damage);

    public void Heal(float healPoints) =>
        Health.Heal(healPoints);
}