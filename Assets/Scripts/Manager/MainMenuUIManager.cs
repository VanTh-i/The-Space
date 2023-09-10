using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = PlayerPrefs.GetInt(PrefConst.COIN_KEY);
        scoreText.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
