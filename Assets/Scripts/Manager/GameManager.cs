using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isDead = false;
    public bool isVictory = false;
    public bool endGame = false;

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

    public void AddScore(int value)
    {
        score += value;
        uiManager.UpdateScore(score);
    }
    public void Victory()
    {
        isVictory = true;

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
    public void Win()
    {
        endGame = true;

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
    public void WaveClear()
    {
        GameObject[] bulletsHell = GameObject.FindGameObjectsWithTag("EnemyBulletHell");
        foreach (GameObject bullet in bulletsHell)
        {
            bullet.gameObject.SetActive(false);
        }
    }
}
