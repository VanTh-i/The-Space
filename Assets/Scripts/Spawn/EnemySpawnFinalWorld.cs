using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnFinalWorld : EnemySpawn
{
    protected override void StageWaveToSpawn()
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
                    GameManager.Instance.Win();
                }
            }
        }
    }

    protected override void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time)
        {
            Vector2 spawnPosition = new Vector2(0, 7);
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
