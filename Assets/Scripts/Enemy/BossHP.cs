using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : EnemyHP
{
    private float bossSizeX;
    private float bossSizeY;
    private Animator animator;
    private BoxCollider2D box;
    protected internal bool stopCoroutine = false;

    private void Start()
    {
        bossSizeX = GetComponent<BoxCollider2D>().size.x /2;
        bossSizeY = GetComponent<BoxCollider2D>().size.y /2;
        animator = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();

    }
    protected override void CallDestroy()
    {
        GameManager.Instance.WaveClear();
        animator.SetTrigger("Destroy");
        box.enabled = false;
        stopCoroutine = true;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    protected override void Explosion()
    {
        StartCoroutine(ExplosionSpawn());
    }
    private IEnumerator ExplosionSpawn()
    {
        
        for (int i = 0; i < 15; i++)
        {
            float spawnPosX = Random.Range(-bossSizeX, bossSizeX);
            float spawnPosY = Random.Range(-bossSizeY, bossSizeY);
            Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, 0) + transform.position;
            GameObject explosion = Instantiate(explosionPrefabs, spawnPos, Quaternion.identity);
            Destroy(explosion, explosionTime);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
