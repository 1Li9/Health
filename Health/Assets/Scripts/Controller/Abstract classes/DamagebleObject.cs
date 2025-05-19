using UnityEngine;

public abstract class DamagebleObject : MonoBehaviour 
{
    public abstract IDamageble Damageble { get;}

    public abstract void TakeDamage(float damage);
    public abstract void Heal(float healPoints);

}
