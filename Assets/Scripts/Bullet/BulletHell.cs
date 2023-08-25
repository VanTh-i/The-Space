using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHell : MonoBehaviour
{
    private Vector2 moveDirection;
    private float speed = 1f;

    private Camera MainCamera;
    private Vector2 Bounds;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Bounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));

        //rb.velocity = moveDirection * speed;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
        Destroy();
    }
    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }
    private void Destroy()
    {
        if (transform.position.x <= -Bounds.x || transform.position.x >= Bounds.x)
        {
            gameObject.SetActive(false);
        }
        if (transform.position.y <= -Bounds.y || transform.position.y >= Bounds.y)
        {
            gameObject.SetActive(false);
        }
    }
}
