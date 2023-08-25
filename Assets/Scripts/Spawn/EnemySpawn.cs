using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Wave[] waves;
    private Wave currentWave;
    private int currentWaveNumber;

    private bool canSpawn = true;
    private bool canAnimate = false;
    private float nextSpawnTime;

    private Animator animator;
    [SerializeField] private TextMeshProUGUI waveName;

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
    private void StageWaveToSpawn()
    {
        currentWave = waves[currentWaveNumber];
        Invoke("SpawnWave", 2.5f);
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (totalEnemies.Length == 0 && !canSpawn && currentWaveNumber + 1 != waves.Length && canAnimate)
        {
            waveName.text = waves[currentWaveNumber + 1].waveName;
            animator.SetTrigger("WaveName");
            canAnimate = false;
        }
        
    }
    private void FirstWave()
    {
        animator.SetTrigger("Wave1");

    }
    public void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }
    private void SpawnWave()
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
