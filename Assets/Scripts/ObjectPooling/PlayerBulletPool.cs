using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletPool : MonoBehaviour
{
    public static PlayerBulletPool Instance;

    private List<GameObject> playerBulletPooled; /*= new List<GameObject>();*/
    //private int amountToPool = 10;
    private bool notEnoughPool = true;

    [SerializeField] private GameObject bulletPrefabs;

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
        playerBulletPooled = new List<GameObject>();
        //for (int i = 0; i < amountToPool; i++)
        //{
        //    GameObject obj = Instantiate(bulletPrefabs);
        //    obj.SetActive(false);
        //    playerBulletPooled.Add(obj);
        //}
    }

    public GameObject GetPooledObject()
    {
        //for (int i = 0; i < playerBulletPooled.Count; i++)
        //{
        //    if (!playerBulletPooled[i].activeInHierarchy)
        //    {
        //        return playerBulletPooled[i];
        //    }
        //}
        if (playerBulletPooled.Count > 0)
        {
            for (int i = 0; i < playerBulletPooled.Count; i++)
            {
                if (!playerBulletPooled[i].activeInHierarchy)
                {
                    return playerBulletPooled[i];
                }
            }
        }

        if (notEnoughPool)
        {
            GameObject obj = Instantiate(bulletPrefabs);
            obj.SetActive(false);
            playerBulletPooled.Add(obj);
            return obj;
        }
        
        return null;
    }
}
