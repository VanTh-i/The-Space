using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : Enemy
{
    protected override void Update()
    {
        Destroy();
        base.Update();
    }

    protected override IEnumerator Shoot()
    {
        while (true)
        {
            //Instantiate(enemyBullet, shootPoint.transform.position, shootPoint.transform.rotation);
            //yield return new WaitForSeconds(0.3f);
            //Instantiate(enemyBullet, shootPoint.transform.position, shootPoint.transform.rotation);
            GameObject bullet = EnemyBulletPool.Instance.GetBullet();
            if (bullet != null)
            {
                bullet.transform.position = shootPoint.transform.position;
                bullet.transform.rotation = shootPoint.transform.rotation;
                bullet.SetActive(true);

            }

            yield return new WaitForSeconds(2f);
        }
    }
    private void Destroy()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
