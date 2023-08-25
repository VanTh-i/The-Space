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
    [SerializeField] private GameObject spawn;
    [SerializeField] private GameObject player;

    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] protected internal int health = 3;
    [SerializeField] private Image[] healthIcon;
    [SerializeField] private Sprite fullHealth;
    [SerializeField] private Sprite emptyHealth;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        scoreText.text = "0";
    }
    private void Update()
    {
        PauseGame();
        DeadMenu();
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
            if (GameManager.Instance.isDead == false)
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
            deadUI.gameObject.SetActive(true);
            Destroy(spawn);
            player.gameObject.SetActive(false);
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
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
