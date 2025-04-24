using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Hearts : MonoBehaviour
{
    //variables 
    public int HeartHealth;
    public int HeartCount;
    int i = 0;//for the ammount of hearts you have displaying on the hud

    //UI Variables
    public Image[] hearts;
    public Sprite Full;
    public Sprite Empty;
    public Score points;
    public GameOver end;
    //
    // Update is called once per frame
    void Update()
    {
        if (HeartHealth > HeartCount)
        {
            HeartHealth = HeartCount;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < HeartHealth)
            {
                hearts[i].sprite = Full;
            }
            else
            {
                hearts[i].sprite = Empty;
            }

            if (i < HeartCount)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }


        }
    }

    public void TakeHeart()
    {
        HeartHealth--;
        hearts[i].sprite = Empty;
        //AudioSourceController.Instance.PlaySFX("Player_Hit");

        if (HeartHealth == 0)
        {
            HeartHealth = 3;
            end.HighscoreText.text = points.ScoreCount.ToString();
            end.Dead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            TakeHeart();
        }
        else if(collision.tag == "Star")
        {
            points.AddScore(10);
        }
    }
}