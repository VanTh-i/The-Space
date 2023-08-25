using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isDead = false;

    private UIManager uiManager;
    private int score;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int value)
    {
        score += value;
        uiManager.UpdateScore(score);
    }
    public void PlayerDead()
    {
        isDead = true;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("EnemyBullet");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }
        GameObject[] bulletsHell = GameObject.FindGameObjectsWithTag("EnemyBulletHell");
        foreach (GameObject bullet in bulletsHell)
        {
            Destroy(bullet);
        }
    }
}
