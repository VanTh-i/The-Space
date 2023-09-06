using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : Enemy
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
            rb.velocity = Vector2.zero;
            //StartCoroutine(MoveHorizontal());
            stopMovingMethod = true;
        }
    }
    protected override IEnumerator Shoot()
    {
        while (true)
        {
            bulletHellFeature2.Fire();
            bulletHellFeature2.Fire2();
            bulletHellFeature2.Fire3();
            bulletHellFeature2.Fire4();
            bulletHellFeature2.Fire5();

            yield return new WaitForSeconds(0.1f);
        }
    }
}
