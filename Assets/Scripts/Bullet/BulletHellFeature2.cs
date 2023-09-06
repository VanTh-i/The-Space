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
    private float angle6 = 0f;
    private float angle7 = 72f;
    private float angle8 = 144f;
    private float angle9 = 216f;
    private float angle10 = 288f;
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

        angle += 5f;
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

        angle2 += 5f;
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

        angle3 += 5f;
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

        angle4 += 5f;
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

        angle5 += 5f;
    }

    protected internal void Fire6()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle6 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle6 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle6 -= 5f;
    }
    protected internal void Fire7()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle7 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle7 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle7 -= 5f;
    }
    protected internal void Fire8()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle8 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle8* Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle8 -= 5f;
    }
    protected internal void Fire9()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle9 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle9 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle9 -= 5f;
    }
    protected internal void Fire10()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle10 * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle10 * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = HellBulletPool.Instance.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<BulletHell>().SetMoveDirection(bulDir);

        angle10 -= 5f;
    }
}
