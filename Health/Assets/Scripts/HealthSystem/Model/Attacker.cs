using UnityEngine;

public class Attacker : InteractableObject
{
    [SerializeField] private HealthHandler _health;
    [Range(1f, 70f)]
    [SerializeField] private float _damage;

    public override void Interact() =>
        _health.TakeDamage(_damage);
}
