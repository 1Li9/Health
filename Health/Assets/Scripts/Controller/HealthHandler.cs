using UnityEngine;

public class HealthHandler : DamagebleObject
{
    [SerializeField] private float _startHealthPoints;

    public override IDamageble Damageble { get => Health; }
    public Health Health { get; private set; }

    private void Awake() =>
        Health = new Health();

    private void Start() =>
        Health.SetHealthPoints(_startHealthPoints);

    public override void TakeDamage(float damage) =>
        Health.TakeDamage(damage);

    public override void Heal(float healPoints) =>
        Health.Heal(healPoints);
}