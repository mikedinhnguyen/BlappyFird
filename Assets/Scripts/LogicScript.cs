using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public Text score;
    public TextMeshProUGUI highScoreText;
    private int highScore = 0;
    private int intScore = 0;
    public AudioSource ding;
    public AudioSource fail;

    private void Start()
    {
        ding.time = 0.25f;
        fail.time = 0.2f;
        highScore = PlayerPrefs.GetInt("highScore");
    }

    public void AddScore(int val)
    {
        intScore += val;
        score.text = intScore.ToString();
    }

    public void PlaySound()
    {
        ding.Play();
    }

    public void PlayFailSound()
    {
        fail.Play();
    }

    public void SaveScore()
    {
        if (highScore < intScore)
        {
            PlayerPrefs.SetInt("highScore", intScore);
            highScore = intScore;
        }

        highScoreText.text = highScore.ToString();
    }

    public void RestartGame()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }
}
