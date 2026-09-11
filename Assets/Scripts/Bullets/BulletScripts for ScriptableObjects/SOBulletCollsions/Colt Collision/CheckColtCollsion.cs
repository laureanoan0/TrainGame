using UnityEngine;

[CreateAssetMenu(fileName = "CheckColtCollisionSO", menuName = "Weapons/Type of collsion/Check Colt collision")]
public class CheckColtCollsion : BulletCollsionTypeSO
{
    public override void BulletCollision(Enemy enemy, BulletScript bulletInfo)
    {
        bool enemyDead = enemy.TakeDamage(bulletInfo.Damage);

        if (enemyDead)
        {
            EventBus.Publish(new OnColtDetectedDeadEnemy(1));
        }

        if (bulletInfo.DestroyOnEnemy)
        {
            bulletInfo.Deactivate();
            return;
        }
    }
}
