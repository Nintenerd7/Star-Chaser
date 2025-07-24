using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOver : MonoBehaviour
{
    public static bool IsDead = false;
    public GameObject GameOverScreen;
    public TMP_Text HighscoreText;
    public Score points;
    public PauseMenu pause;
    void Update()
    {
        if (IsDead)
        {
            pause.canPause = false;//player can't pause when game over menu is active
        }
        else
        {
            pause.canPause = true;//player can pause any time its alive
        }
    }

    public void Dead()
    {
        Time.timeScale = 0f;
        AudioSourceController.Instance.PlaySFX("GameOver");
        IsDead = true;
        GameOverScreen.SetActive(true);

    }
    public void Restart()
    {
        Time.timeScale = 1f;
        points.ScoreCount = 0;
        points.ScoreText.text = "0";
        IsDead = false;
        SceneManager.LoadScene(1);
    }
}
