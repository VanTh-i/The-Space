using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : Enemy
{
    private float distanceEnemyB = 3.5f;
    //[SerializeField] protected internal GameObject shootPoint2 , shootPoint3;

    protected override void Moving()
    {
        if (transform.position.y > distanceEnemyB)
        {
            rb.velocity = Vector2.down * enemySpeed;
        }
        else
        {
            //bulletHellFeature.Fire();
            StartCoroutine(Shoot());
            rb.velocity = Vector2.zero;
            stopMovingMethod = true;
        }
    }

    protected override IEnumerator Shoot()
    {
        while (true)
        {
            bulletHellFeature.Fire();
            //yield return new WaitForSeconds(0.7f);

            yield return new WaitForSeconds(2f);

        }
    }

}
