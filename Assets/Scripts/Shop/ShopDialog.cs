using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDialog : Dialog
{
    public Transform gridRoot;
    public ShopItemUI ItemUIPrefabs;

    public override void Show(bool isShow)
    {
        base.Show(isShow);
        UpdateUI();
    }

    private void UpdateUI()
    {
        var items = shopManager.items;

        if (items == null || items.Length <= 0 || !gridRoot || !ItemUIPrefabs)
        {
            return;
        }

        ClearChildsItem();

        for (int i = 0; i < items.Length; i++)
        {
            int idx = i;
            var item = items[i];
            if (item != null)
            {
                var itemUIClone = Instantiate(ItemUIPrefabs, Vector3.zero, Quaternion.identity);
                itemUIClone.transform.SetParent(gridRoot);
                itemUIClone.transform.localPosition = Vector3.zero;
                itemUIClone.transform.localScale = Vector3.one;
                itemUIClone.UpdateUI(item, idx);

                if (itemUIClone.btn)
                {
                    itemUIClone.btn.onClick.RemoveAllListeners();
                    itemUIClone.btn.onClick.AddListener(() => ItemEvent(item, idx));
                }
            }
        }
    }

    private void ItemEvent(ShopItem item, int shopItemID)
    {
        if (item == null)
        {
            return;
        }

        bool isUnlocked = Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemID);
        if (isUnlocked)
        {
            if (shopItemID == Pref.CurPlayerID)
            {
                return;
            }

            Pref.CurPlayerID = shopItemID;
            SpawnPlayerInShop.Instance.ChoosePlayer();
            UpdateUI();
        }
        else
        {
            if (Pref.Coins >= item.price)
            {
                Pref.Coins -= item.price;
                Pref.SetBool(PrefConst.PLAYER_PEFIX + shopItemID, true);
                Pref.CurPlayerID = shopItemID;
                MainMenuUIManager.Instance.UpdateCoin();
                SpawnPlayerInShop.Instance.ChoosePlayer();
                UpdateUI();
            }
            else
            {
                Debug.Log("ko du tien mua !!!");
            }
        }
    }
    public void ClearChildsItem()
    {
        if (!gridRoot || gridRoot.childCount <= 0)
        {
            return;
        }

        for (int i = 0; i < gridRoot.childCount; i++)
        {
            var child = gridRoot.GetChild(i);
            if (child)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
