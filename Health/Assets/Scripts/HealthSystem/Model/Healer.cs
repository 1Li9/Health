using UnityEngine;

public class Healer : InteractableObject
{
    [SerializeField] private HealthHandler _health;
    [Range(1f, 70f)]
    [SerializeField] private float _healPpoints;

    public override void Interact() =>
        _health.Increase(_healPpoints);
}
