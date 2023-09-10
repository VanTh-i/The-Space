using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pref
{
    public static int CurPlayerID
    {
        get => PlayerPrefs.GetInt(PrefConst.CUR_PLAYER_ID);
        set => PlayerPrefs.SetInt(PrefConst.CUR_PLAYER_ID, value);
    }
    public static int Coins
    {
        get => PlayerPrefs.GetInt(PrefConst.COIN_KEY);
        set => PlayerPrefs.SetInt(PrefConst.COIN_KEY, value);
    }
    public static void SetBool(string key, bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt(key, 1);
        }
        else
        {
            PlayerPrefs.SetInt(key, 0);
        }
    }
    public static bool GetBool(string key)
    {
        if (PlayerPrefs.GetInt(key) == 1)
        {
            return true;
        }
        else return false;
    }
}
