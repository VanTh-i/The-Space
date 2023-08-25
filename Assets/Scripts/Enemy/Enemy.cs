using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected float enemySpeed = 2f;

    protected bool stopMovingMethod;
    protected float distance;

    [SerializeField] protected GameObject enemyBullet;
    [SerializeField] protected internal GameObject shootPoint;

    protected BulletHellFeature bulletHellFeature;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletHellFeature = FindObjectOfType<BulletHellFeature>();
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
    protected virtual void Moving()
    {
        if (transform.position.y > distance)
        {
            rb.velocity = Vector2.down * enemySpeed;
        }
        else
        {
            StartCoroutine(Shoot());
            rb.velocity = Vector2.zero;
            stopMovingMethod = true;
        }
    }

    protected virtual IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(enemyBullet, shootPoint.transform.position, shootPoint.transform.rotation);
            yield return new WaitForSeconds(3f);
        }
    }

}
