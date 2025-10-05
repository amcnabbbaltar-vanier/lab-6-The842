using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    private int targetScore = 4;


    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }


    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }

    public void LoadNextScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
}


