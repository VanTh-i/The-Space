using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] protected Wave[] waves;
    protected Wave currentWave;
    protected int currentWaveNumber;

    protected bool canSpawn = true;
    protected bool canAnimate = false;
    protected float nextSpawnTime;

    protected Animator animator;
    [SerializeField] protected TextMeshProUGUI waveName;
    [SerializeField] private TextMeshProUGUI worldName;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("FirstWave" , 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        StageWaveToSpawn();
    }
    protected virtual void StageWaveToSpawn()
    {
        currentWave = waves[currentWaveNumber];
        Invoke("SpawnWave", 2.5f);
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (totalEnemies.Length == 0)
        {
            if (currentWaveNumber + 1 != waves.Length)
            {
                if (canAnimate)
                {
                    waveName.text = waves[currentWaveNumber + 1].waveName;
                    animator.SetTrigger("WaveName");
                    canAnimate = false;
                }
            }
            else
            {
                if (currentWave.numOfEnemy <= 0)
                {
                    GameManager.Instance.Victory();
                }
            }
        }
    }
    private void FirstWave()
    {
        worldName.text = "World " + SceneManager.GetActiveScene().buildIndex;
        animator.SetTrigger("Wave1");

    }
    public void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }
    protected virtual void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            float spawnX = Random.Range(-2.5f, 2.5f);
            Vector2 spawnPosition = new Vector2(spawnX, 7);
            Instantiate(currentWave.typeOfEnemy, spawnPosition, Quaternion.identity);

            currentWave.numOfEnemy--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;

            if (currentWave.numOfEnemy == 0)
            {
                canSpawn = false;
                canAnimate = true;
            }
        }
    }
}

[System.Serializable]
public class Wave
{
    [SerializeField] protected internal string waveName;
    public int numOfEnemy;
    public GameObject typeOfEnemy;
    protected internal float spawnInterval = 1f;
}
