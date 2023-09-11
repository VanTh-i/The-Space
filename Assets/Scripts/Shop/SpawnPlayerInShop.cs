using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayerInShop : MonoBehaviour
{
    public static SpawnPlayerInShop Instance;
    private ShopManager shopManager;
    public GameObject player;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }
    public void ChoosePlayer()
    {
        var newPlayerPb = shopManager.items[Pref.CurPlayerID].playerPrefab;
    }
    public void ActivePlayer()
    {
        var newPlayerPb = shopManager.items[Pref.CurPlayerID].playerPrefab;
        if (newPlayerPb)
        {
            player = Instantiate(newPlayerPb);
        }
    }
}
