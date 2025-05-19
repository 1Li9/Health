using UnityEngine;

public class AttackerHandler : MonoBehaviour
{
    [SerializeField] private DamagebleObject _damageble;
    [Range(5f, 70f)]
    [SerializeField] private float _damage;

    private Attacker _attacker;

    private void Start() =>
        _attacker = new Attacker(_damageble.Damageble, _damage);

    public void Attack() =>
        _attacker.Attack();
}
