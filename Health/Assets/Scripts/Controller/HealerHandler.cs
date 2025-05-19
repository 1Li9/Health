using UnityEngine;

public class HealerHandler : MonoBehaviour
{
    [SerializeField] private DamagebleObject _damageble;
    [Range(5f, 70f)]
    [SerializeField] private float _healPoints;

    private Healer _healer;

    private void Start() =>
        _healer = new Healer(_damageble.Damageble, _healPoints);

    public void Heal() =>
        _healer.Heal();
}
