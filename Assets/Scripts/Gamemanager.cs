using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    [Header("InGame")]
    [SerializeField] private GameObject inGameUI;
    [SerializeField] private TextMeshProUGUI inGameScoreText;

    [Header("GameOver")]
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TextMeshProUGUI gameOverScoreText;

    [Header("Sounds")]
    [SerializeField] private AudioSource checkPointSound;
    [SerializeField] private AudioSource gameOverSound;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        checkPointSound = GetComponents<AudioSource>()[0];
        gameOverSound = GetComponents<AudioSource>()[1];
    }

    public void GameOver()
    {
        gameOverSound.Play();
        gameOverUI.SetActive(true);
        inGameUI.SetActive(false);
        gameOverScoreText.text = score.ToString();
        Time.timeScale = 0;
    }

    public void increment_score()
    {
        checkPointSound.Play();
        score++;
    }

    public void Restart()
    {
        score = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);      
    }

    public void QUIT()
    {
        Application.Quit();
    }

    private void Update() { 
        inGameScoreText.text = score.ToString();
    }
}
