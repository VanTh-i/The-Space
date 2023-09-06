using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : Enemy
{
    private float distanceBoss1 = 3.5f;

    protected override void Update()
    {
        StopBehavior();// dung ban dan khi chet

        base.Update();
    }
    protected override void Moving()
    {
        if (transform.position.y > distanceBoss1)
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
            for (int i = 0; i < 4; i++)
            {
                bulletHellFeature.Fire();
                yield return new WaitForSeconds(0.7f);
                bulletHellFeature.Fire2();
                yield return new WaitForSeconds(0.7f);
            }
            //bulletHellFeature.FireRandom();
            yield return new WaitForSeconds(2f);
        }
    }
    protected override IEnumerator MoveHorizontal()
    {
        while (true)
        {
            if (movingToX)
            {
                rb.velocity = Vector2.left * (enemySpeed / 10);
                if (transform.position.x <= -Bound.x)
                {
                    movingToX = false;
                }
            }

            else if (movingToX == false)
            {
                rb.velocity = Vector2.right * (enemySpeed / 10);
                if (transform.position.x >= Bound.x)
                {
                    movingToX = true;
                }
            }
            yield return null;
        }
    }
}
