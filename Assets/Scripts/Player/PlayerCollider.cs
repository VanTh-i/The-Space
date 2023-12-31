using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private PlayerHP playerHP;
    private UIManager uiManager;
    private Animator animator;



    private void Start()
    {
        playerHP = FindObjectOfType<PlayerHP>();
        uiManager = FindObjectOfType<UIManager>();
        animator = GetComponent<Animator>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet") || collision.gameObject.CompareTag("EnemyBulletHell"))
        {
            if (playerHP.maxHP >= 1)
            {
                GetIFrame();
                collision.gameObject.SetActive(false);
            }
        }
        
    }
    private void GetIFrame()
    {
        playerHP.HitByEnemy(1);
        uiManager.health--;
        StartCoroutine(IFrame());
    }
    IEnumerator IFrame()
    {
        Physics2D.IgnoreLayerCollision(6, 7, true);
        animator.SetTrigger("IFrame");

        yield return new WaitForSeconds(2f);

        Physics2D.IgnoreLayerCollision(6, 7, false);
        animator.SetTrigger("EndIFrame");
    }
    private void OnDisable()
    {
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }
}
