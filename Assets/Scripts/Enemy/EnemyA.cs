using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : Enemy
{
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
