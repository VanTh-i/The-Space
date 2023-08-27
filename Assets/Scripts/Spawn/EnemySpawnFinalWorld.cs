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
}
