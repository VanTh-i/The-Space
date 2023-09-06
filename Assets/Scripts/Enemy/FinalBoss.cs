using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : Enemy
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
            //StartCoroutine(Shoot());
            //StartCoroutine(Shoot2());
            StartCoroutine(Shoot3());
            //rb.velocity = Vector2.zero;
            StartCoroutine(MoveHorizontal());
            stopMovingMethod = true;
        }
    }

    protected override IEnumerator MoveHorizontal()
    {
        while (true)
        {
            if (movingToX)
            {
                //rb.velocity = Vector2.left * (enemySpeed / 10);
                rb.velocity = Vector2.left * (enemySpeed - enemySpeed);
                if (transform.position.x <= -1)
                {
                    movingToX = false;
                }
            }

            else if (movingToX == false)
            {
                //rb.velocity = Vector2.right * (enemySpeed / 10);
                rb.velocity = Vector2.left * (enemySpeed - enemySpeed);
                if (transform.position.x >= 1)
                {
                    movingToX = true;
                }
            }
            yield return null;
        }
    }
    protected override IEnumerator Shoot()
    {
        while (true)
        {
            //bulletHellFeature2.Fire();
            //bulletHellFeature2.Fire2();
            //bulletHellFeature2.Fire3();
            //bulletHellFeature2.Fire4();
            //bulletHellFeature2.Fire5();
            bulletHellFeature3.Fire();
            bulletHellFeature3.Fire2();

            yield return new WaitForSeconds(0.5f);
        }
    }
    private IEnumerator Shoot2()
    {
        while (true)
        {
            bulletHellFeature.Fire();
            yield return new WaitForSeconds(0.7f);
            bulletHellFeature.Fire2();
            yield return new WaitForSeconds(0.7f);
        }
    }
    private IEnumerator Shoot3()
    {
        while (true)
        {
            bulletHellFeature3.Fire();
            bulletHellFeature3.Fire2();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
