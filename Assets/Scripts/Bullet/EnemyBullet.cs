using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    protected float speed = 1.2f;
    Rigidbody2D rb;
    protected GameObject player;

    private Camera MainCamera;
    private Vector2 Bounds;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //player = GameObject.FindGameObjectWithTag("Player");
        //DirectionToPlayer();

        //MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        //Bounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        DirectionToPlayer();

        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Bounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        BulletSelfDestroy();
        
    }
    protected virtual void DirectionToPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float angle = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    private void BulletSelfDestroy()
    {
        if (transform.position.x <= -Bounds.x || transform.position.x >= Bounds.x)
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
        if (transform.position.y <= -Bounds.y || transform.position.y >= Bounds.y)
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
