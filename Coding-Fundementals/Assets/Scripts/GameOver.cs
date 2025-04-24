using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    bool IsDead = false;
    public GameObject GameOverScreen;

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
        IsDead = false;
        SceneManager.LoadScene(0);
    }
}
