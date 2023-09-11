using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    private bool isPaused = false;

    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject deadUI;
    [SerializeField] private GameObject victoryUI;
    [SerializeField] private GameObject endGameUI;

    [SerializeField] private GameObject spawn;
    private GameObject player;

    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] protected internal int health = 3;
    [SerializeField] private Image[] healthIcon;
    [SerializeField] private Sprite fullHealth;
    [SerializeField] private Sprite emptyHealth;

    private void Start()
    {
        GameManager.Instance.score = PlayerPrefs.GetInt(PrefConst.COIN_KEY);
        scoreText.text = (GameManager.Instance.score).ToString();
    }
    private void Update()
    {
        PauseGame();
        DeadMenu();
        VictoryMenu();
        EndGameMenu();
        Health();
    }
    protected internal void UpdateScore(int value)
    {
        scoreText.text = value.ToString();
    }
    private void Health()
    {
        foreach (Image img in healthIcon)
        {
            img.sprite = emptyHealth;
        }
        for (int i = 0; i < health; i++)
        {
            healthIcon[i].sprite = fullHealth;
        }
    }
    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GameManager.Instance.isDead || !GameManager.Instance.isVictory)
            {
                isPaused = !isPaused;
            }
            else return;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            pauseUI.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseUI.gameObject.SetActive(false);
        }
    }
    public void DeadMenu()
    {
        if (GameManager.Instance.isDead)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            deadUI.gameObject.SetActive(true);
            Destroy(spawn);
            Destroy(player);
            //player.gameObject.SetActive(false);
        }
    }
    public void VictoryMenu()
    {
        if (GameManager.Instance.isVictory)
        {
            victoryUI.gameObject.SetActive(true);
        }
    }
    public void EndGameMenu()
    {
        if (GameManager.Instance.endGame)
        {
            endGameUI.gameObject.SetActive(true);
        }
    }

    public void Continue()
    {
        isPaused = false;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
