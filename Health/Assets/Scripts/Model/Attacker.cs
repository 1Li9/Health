public class Attacker
{
    private IDamageble _damageble;
    private float _damage;

    public Attacker(IDamageble damageble, float damage)
    {
        _damageble = damageble;
        _damage = damage;
    }

    public void Attack() =>
        _damageble.TakeDamage(_damage);
}