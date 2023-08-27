using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellFeature2 : MonoBehaviour
{
    private float angle = 0f;
    private float angle2 = 72f;
    private float angle3 = 144f;
    private float angle4 = 216f;
    private float angle5 = 288f;
    protected internal void Fire()
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

        angle += 10f;
    }
    protected internal void Fire2()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle2 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle2 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle2 += 10f;
    }
    protected internal void Fire3()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle3 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle3 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle3 += 10f;
    }
    protected internal void Fire4()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle4 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle4 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle4 += 10f;
    }
    protected internal void Fire5()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle5 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle5 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle5 += 10f;
    }
}
