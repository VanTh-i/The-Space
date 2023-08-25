using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellBulletPool : MonoBehaviour
{
    public static HellBulletPool Instance;

    [SerializeField] private GameObject hellBulletPrefabs;
    private bool notEnoughPool = true;
    private List<GameObject> bullets;
    private void Awake()
    {
        Instance = this;
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
            GameObject bul = Instantiate(hellBulletPrefabs);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }
        return null;
    }
}
