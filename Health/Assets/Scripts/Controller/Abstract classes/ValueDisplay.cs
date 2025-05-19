using UnityEngine;

public abstract class ValueDisplay : MonoBehaviour
{
    public virtual float MaxValue { get; set; }
    public abstract float Value { get; set; }
}
