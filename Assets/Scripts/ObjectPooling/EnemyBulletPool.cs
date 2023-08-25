using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPool : MonoBehaviour
{
    public static EnemyBulletPool Instance;

    [SerializeField] private GameObject enemyBulletPrefabs;
    private bool notEnoughPool = true;
    private List<GameObject> bullets;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }

    public GameObject GetBullet()
    {
        if (bullets.Count > 0)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    return bullets[i];
                }
            }
        }

        if (notEnoughPool)
        {
            GameObject obj = Instantiate(enemyBulletPrefabs);
            obj.SetActive(false);
            bullets.Add(obj);
            return obj;
        }
        return null;
    }
}
