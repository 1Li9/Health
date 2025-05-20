using System;

public class Health
{
    private float healthPoints;
    private float maxHealthPoints;

    public event Action<float> OnHealthPointsChanged;
    public event Action<float> OnMaxHealthPointsChanged;

    public float HealthPoints
    {
        get => healthPoints;

        private set
        {
            healthPoints = value;
            OnHealthPointsChanged?.Invoke(healthPoints);
        }
    }

    public float MaxHealthPoints
    {
        get => maxHealthPoints;

        private set
        {
            maxHealthPoints = value;
            OnMaxHealthPointsChanged?.Invoke(maxHealthPoints);
        }
    }

    public bool IsAlive { get; private set; } = true;

    public void SetHealthPoints(float health)
    {
        MaxHealthPoints = health;
        HealthPoints = MaxHealthPoints;
    }

    public void TakeDamage(float damage)
    {
        if (IsAlive == false)
            return;

        if (HealthPoints - damage <= 0)
        {
            HealthPoints = 0;
            IsAlive = false;

            return;
        }

        HealthPoints -= damage;
    }

    public void Heal(float healPoints)
    {
        if (IsAlive == false)
            return;

        if (HealthPoints + healPoints >= MaxHealthPoints)
        {
            HealthPoints = MaxHealthPoints;

            return;
        }

        HealthPoints += healPoints;
    }
}