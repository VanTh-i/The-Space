using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private EnemyHP enemyHP;
    private void Start()
    {
        enemyHP = FindObjectOfType<EnemyHP>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            enemyHP.HitEnemy(1);
            collision.gameObject.SetActive(false);
        }
    }
}
