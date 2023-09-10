using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Image hud;
    [SerializeField] private Button btn;

    public void UpdateUI(ShopItem item, int shopItemID)
    {
        if (item == null)
        {
            return;
        }

        if (hud)
            hud.sprite = item.hud;

        bool isUnlocked = Pref.GetBool(PrefConst.PLAYER_PEFIX + shopItemID);
        if (isUnlocked)
        {
            if (shopItemID == Pref.CurPlayerID)
            {
                if (priceText)
                {
                    priceText.text = "Active";
                }
            }
            else
            {
                if (priceText)
                {
                    priceText.text = "OWNED";
                }
            }
        }
        else
        {
            if (priceText)
            {
                priceText.text = item.price.ToString();
            }
        }
    }

}
