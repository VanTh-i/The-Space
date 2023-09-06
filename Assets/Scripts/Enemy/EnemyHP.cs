using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int maxHP = 20;
    [SerializeField] protected GameObject explosionPrefabs;
    [SerializeField] protected float explosionTime;

    public void HitEnemy(int value)
    {
        maxHP -= value;
        if (maxHP <= 0)
        {
            GameManager.Instance.AddScore(1);
            CallDestroy();
            Explosion();
        }
    }
    protected virtual void CallDestroy()
    {
        Destroy(gameObject);
    }
    protected virtual void Explosion()
    {
        GameObject explosion = Instantiate(explosionPrefabs, transform.position, transform.rotation);
        Destroy(explosion, explosionTime);
    }
}
