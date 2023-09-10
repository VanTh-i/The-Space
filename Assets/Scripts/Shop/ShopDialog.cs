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