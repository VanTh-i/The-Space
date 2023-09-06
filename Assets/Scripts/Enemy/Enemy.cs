using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected float enemySpeed = 2f;

    protected bool stopMovingMethod;
    protected float distance;

    public bool movingToX = true;

    [SerializeField] protected GameObject enemyBullet;

    protected BulletHellFeature bulletHellFeature;
    protected BulletHellFeature2 bulletHellFeature2;
    protected BulletHellFeature3 bulletHellFeature3;

    private Camera MainCamera;
    protected Vector2 Bound;

    private BossHP bossHP;

    // Start is called before the first frame update
    private void Start()
    {
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Bound = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));

        rb = GetComponent<Rigidbody2D>();
        bulletHellFeature = FindObjectOfType<BulletHellFeature>();
        bulletHellFeature2 = FindObjectOfType<BulletHellFeature2>();
        bulletHellFeature3 = FindObjectOfType<BulletHellFeature3>();

        bossHP = GetComponent<BossHP>();
        

        distance = Random.Range(2f, 4.5f);
        stopMovingMethod = false;
    }

    // Update is called once per frame
    protected virtual void Update()
    {

        if (!stopMovingMethod)
        {
            Moving();
        }
    }
    protected void StopBehavior()
    {
        if (bossHP.stopCoroutine)
        {
            StopAllCoroutines();
        }
    }
    protected virtual void Moving()
    {
        if (transform.position.y > distance)
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

    protected abstract IEnumerator Shoot();
    //{
    //    while (true)
    //    {
    //        Instantiate(enemyBullet, shootPoint.transform.position, shootPoint.transform.rotation);
    //        yield return new WaitForSeconds(3f);
    //    }
    //}
    protected virtual IEnumerator MoveHorizontal()
    {
        while (true)
        {
            if (movingToX)
            {
                rb.velocity = Vector2.left * (enemySpeed / 2);
                if (transform.position.x <= -Bound.x)
                {
                    movingToX = false;
                }
            }

            else if (movingToX == false)
            {
                rb.velocity = Vector2.right * (enemySpeed / 2);
                if (transform.position.x >= Bound.x)
                {
                    movingToX = true;
                }
            }
            yield return null;
        }
    }
}
