using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    bool IsDead = false;
    public GameObject GameOverScreen;
    public TMP_Text HighscoreText;
    public Score points;
    void Update()
    {
        if (IsDead)
        {
            Time.timeScale = 0f;
        }
        else
        {
            GameOverScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void Dead()
    {
        IsDead = true;
        GameOverScreen.SetActive(true);

    }
    public void Restart()
    {
        points.ScoreCount = 0;
        points.ScoreText.text = "0";
        IsDead = false;
        SceneManager.LoadScene(0);
    }
}
