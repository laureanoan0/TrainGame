using UnityEngine;

[CreateAssetMenu(fileName = "New collsion", menuName = "Weapons/Type of collsion/Base bullet collsion")]
public class BaseBulletCollsionSO : BulletCollsionTypeSO
{
    public override void BulletCollision(Enemy enemy, BulletScript bulletInfo)
    {
        enemy.TakeDamage(bulletInfo.Damage);

        if (bulletInfo.DestroyOnEnemy)
        {
            bulletInfo.Deactivate();
            return;
        }
    }
}
