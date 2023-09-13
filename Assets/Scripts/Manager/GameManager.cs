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
    protected internal int score;

    //event
    public event System.Action PlayerDied;
    public event System.Action VictoryEvent;
    public event System.Action WinEvent;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayerInShop.Instance.ActivePlayer();
        score = PlayerPrefs.GetInt(PrefConst.COIN_KEY);
        uiManager = FindObjectOfType<UIManager>();
    }

    public void AddScore(int value)
    {
        score += value;
        uiManager.UpdateScore(score);

        PlayerPrefs.SetInt(PrefConst.COIN_KEY, score);//luu tru coin
        PlayerPrefs.Save();
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

        VictoryEvent?.Invoke();
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

        WinEvent?.Invoke();
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

        PlayerDied?.Invoke();
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
