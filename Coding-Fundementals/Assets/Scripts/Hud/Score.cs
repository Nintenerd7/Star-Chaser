using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class Score : MonoBehaviour
{
    public int ScoreCount;//stores add score parameter 
    public TMP_Text ScoreText;//displays text on UI 
    public int Points_Collected;//math modifier for fever mode 
    bool ScoreMore;//stores score check parameter 

public void ScoreModifier()
    {
      if(Points_Collected >= 0)//if points collected is more than equal to zero
        {
            Debug.Log(Points_Collected);//print out points collected 
            ScoreCheck(false);//score more is equal to false 
        }
      if (Points_Collected == 10)//if points collected is equal to ten 
        {
            StartCoroutine(Fever_Timer());//start fever timer 
        }
    }

    // Start is called before the first frame update
    public void AddScore(int score)
    {
            ScoreCount += score;// Set score count to add score parameter values to method
            Points_Collected++;// count up points collected before reaching fever 
            ScoreText.text = ScoreCount.ToString();//display values on user interface 
    }

    public IEnumerator Fever_Timer()
    {
        Debug.Log("FEVER");
        ScoreCheck(true);
        yield return new WaitForSeconds(10f);
        Points_Collected = 0;
        ScoreCheck(false);
        yield break;
    }

    public void ScoreCheck(bool canScore)
    {
        ScoreMore = canScore;

        switch (canScore)
        {
            case true:
                AddScore(20);
                break;
                case false:
                AddScore(10);
                break;
        }
    }

}
