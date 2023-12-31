using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellFeature : MonoBehaviour
{
    [SerializeField] private int bulletAmount = 10;
    [SerializeField] private float startAngle = 90f, endAngle = 270f;
    //private Vector2 bulletMoveDirection;
    protected internal void Fire()
    {
        float angleStep = (endAngle - startAngle) / bulletAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = HellBulletPool.Instance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

            angle += angleStep;
        }     
    }

    protected internal void Fire2()
    {
        float angleStep = (endAngle - startAngle) / bulletAmount;
        float angle = startAngle + ((endAngle - startAngle) / bulletAmount) /2;

        for (int i = 0; i < bulletAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = HellBulletPool.Instance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }
}
