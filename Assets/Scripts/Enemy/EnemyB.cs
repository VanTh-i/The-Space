using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : Enemy
{
    private float distanceEnemyB = 3.5f;

    protected override void Moving()
    {
        if (transform.position.y > distanceEnemyB)
        {
            rb.velocity = Vector2.down * enemySpeed;
        }
        else
        {
            StartCoroutine(Shoot());
            //rb.velocity = Vector2.zero;
            StartCoroutine(MoveHorizontal());
            stopMovingMethod = true;
        }
    }

    protected override IEnumerator Shoot()
    {
        while (true)
        {
            bulletHellFeature.Fire();
            //yield return new WaitForSeconds(0.7f);
            //bulletHellFeature.Fire2();
            yield return new WaitForSeconds(2f);

        }
    }

}
