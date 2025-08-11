using UnityEngine;

public class CircleEnemy : Enemy, IEnemy
{
    public void Kill() => Destroy(this.gameObject);


    public void GetDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    

    public int GetEnemyDamage() => Damage;
}