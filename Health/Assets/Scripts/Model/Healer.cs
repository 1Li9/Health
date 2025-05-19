public class Healer
{
    private IDamageble _damageble;
    private float _healPoints;

    public Healer(IDamageble damageble, float healPoints)
    {
        _damageble = damageble;
        _healPoints = healPoints;
    }

    public void Heal() =>
        _damageble.Heal(_healPoints);
}
