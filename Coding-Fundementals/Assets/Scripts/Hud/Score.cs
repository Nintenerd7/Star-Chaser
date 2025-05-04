using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;


public class Score : MonoBehaviour
{
    public int ScoreCount;//stores add score parameter 
    public TMP_Text ScoreText;//displays text on UI 
    public GameObject feverAlertPlaceholder;//place holder for fever alert 
    public int Points_Collected;//math modifier for fever mode 
    bool ScoreMore;//stores score check parameter
    public ScoreMode Score_Mode;//States that change the score points from normal to fever 

    private void Start()
    {
        ScoreText.text = "0";//Score states at zero
    }

    public void ScoreModifier()
    {
        //STATE MODIFIER 
        switch (Score_Mode)
        {
            case ScoreMode.normal://Normal State handles the normal score system for the game
                AddScore(10);//10 score points get added to UI 
                break;

            case ScoreMode.fever://Fever State handles the bonus mode for the game 
                AddScore(20);//Score points get doubled to 20
                StartCoroutine(Fever_Timer());//start the fever timer for 7 seconds 
                break;
        }
        Score_Mode = ScoreMode.normal;//score state is set to normal 

        if (Points_Collected == 10)//if points collected is equal to ten 
        {
            Score_Mode = ScoreMode.fever;//set score state to fever time 
        }
    }

    // Add score method 
    public void AddScore(int score)//Method and parameter is used to add score onto the players hud 
    {
            ScoreCount += score;// Set score count to add score parameter values to method
            Points_Collected++;// count up points collected before reaching fever 
            ScoreText.text = ScoreCount.ToString("0");//display values on user interface 
    }

    // fever Timer enumerator 
    public IEnumerator Fever_Timer()
    {
        Debug.Log("FEVER");//print out in console 
        feverAlertPlaceholder.SetActive(true);//set active to true
        Points_Collected = 10;//max points collected are equal to 10
        yield return new WaitForSeconds(7f);//Wait for 7 seconds 
        feverAlertPlaceholder.SetActive(false);//set active to false
        Points_Collected = 0;//Points reset to zero
        Score_Mode = ScoreMode.normal;//states return to normal
        yield break;//ends couroutine 
    }

    //state machine enums 
    public enum ScoreMode
    {
        normal,
        fever,
    }

}
