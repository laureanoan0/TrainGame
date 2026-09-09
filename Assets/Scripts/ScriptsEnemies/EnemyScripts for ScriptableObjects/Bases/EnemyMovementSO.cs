using UnityEngine;

public abstract class EnemyMovementSO : ScriptableObject
{
    public abstract void Knockback(Enemy enemy);

    public abstract void Move(Enemy enemy);
}
