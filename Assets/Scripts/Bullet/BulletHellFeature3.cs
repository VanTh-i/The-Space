using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellFeature3 : MonoBehaviour
{
    private float angle = 0f;
    private float angle2 = 350f;

    protected internal void Fire()
    {
        for (int i = 0; i <= 10; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle + 36f * i) * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle + 36f * i) * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = HellBulletPool.Instance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);
        }

        angle += 20f;
    }

    protected internal void Fire2()
    {
        for (int i = 0; i <= 10; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle2 + 36f * i) * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle2 + 36f * i) * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = HellBulletPool.Instance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);
        }

        angle2 -= 20f;
    }
}
