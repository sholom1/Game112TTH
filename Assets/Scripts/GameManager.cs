using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI ScoreText;
    public int RequiredScore;
    private int score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;

        ScoreText.text = $"${score.ToString()} / {RequiredScore}";
    }
    
    public void UpdateScore(int amount)
    {
        score += amount;
        ScoreText.text = $"${score.ToString()} / {RequiredScore}";
        if (score >= RequiredScore)
        {
            SceneManager.LoadScene(0);
        }
    }
}
