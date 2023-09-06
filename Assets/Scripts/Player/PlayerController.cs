using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Rigidbody2D rb;

    [SerializeField]
    private GameObject bulletPrefabs;
    float fireRate = 0.1f;
    float lastFireTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerShoot();
        SlowMove();
    }
    private void PlayerMove()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);
        movement.Normalize();

        rb.velocity = movement * moveSpeed;
    }
    private void PlayerShoot()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time - lastFireTime > fireRate)
            {
                GameObject bullet = PlayerBulletPool.Instance.GetPooledObject();
                if (bullet != null)
                {
                    bullet.transform.position = transform.position;
                    bullet.transform.rotation = transform.rotation;
                    bullet.SetActive(true);
                }
                lastFireTime = Time.time;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = PlayerBulletPool.Instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
            }
        }
    }
    private void SlowMove()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 1.5f;
        }
        else moveSpeed = 5f;
    }
}
