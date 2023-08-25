using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int maxHP = 20;

    public void HitEnemy(int value)
    {
        maxHP -= value;
        if (maxHP <= 0)
        {
            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
