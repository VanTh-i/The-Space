using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] protected internal int maxHP = 3;

    private void Start()
    {

    }
    public void HitByEnemy(int value)
    {
        maxHP -= value;
        // do sth
        if (maxHP <= 0)
        {
            GameManager.Instance.PlayerDead();
        }
    }
}
