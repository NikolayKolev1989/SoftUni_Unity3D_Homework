
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject startGameScreen;
    public GameObject gameOverScreen;

    public float maxHealth = 15;
    public Slider healthSlider;
    public Text scoreText;
    private int currentScore;



    private void Awake()
    {
        showStartGameScreen();
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
        updateScore(0);
    }

    private void Update()
    {
        healthSlider.value -= Time.deltaTime;
        if (healthSlider.value <= 0)
        {
            showGameOverScreen();
        }
    }

    public void showStartGameScreen()
    {
        Time.timeScale = 0;
        gameScreen.SetActive(false);
        startGameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    public void onStartGameClicked()
    {
        Time.timeScale = 1;
        gameScreen.SetActive(true);
        startGameScreen.SetActive(false);
        gameOverScreen.SetActive(false);
    }

    public void showGameOverScreen()
    {
        Time.timeScale = 0;
        gameScreen.SetActive(false);
        startGameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }

    public void onRestartGameClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("{SceneName}");
    }

    public void updateScore(int value)
    {
        currentScore += value;
        scoreText.text = $"Score: {currentScore}";
    }

    public void updateHealth(float value)
    {
        healthSlider.value += value;
    }
}
