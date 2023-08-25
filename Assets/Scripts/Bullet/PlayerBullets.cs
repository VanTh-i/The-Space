using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    private Rigidbody2D rb;
    private float bulletSpeed = 10f;

    private Camera MainCamera;
    private Vector2 Bounds;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Bounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    private void Shoot()
    {
        rb.velocity = transform.up * bulletSpeed;
        if (transform.position.y >= Bounds.y)
        {
            gameObject.SetActive(false);
        }
    }
}
