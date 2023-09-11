using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MainMenuUIManager : MonoBehaviour
{
    public static MainMenuUIManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int coins;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt(PrefConst.COIN_KEY);
        scoreText.text = coins.ToString();
    }

    public void GetFreeCoin()
    {
        Pref.Coins += 10000;
        coins = Pref.Coins;
        UpdateCoin();
    }
    public void UpdateCoin()
    {
        if (scoreText)
        {
            coins = Pref.Coins;
            scoreText.text = Pref.Coins.ToString();
        }
    }
}
