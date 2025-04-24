using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public int ScoreCount;
    public TMP_Text ScoreText;
    public Hearts die;
    // Start is called before the first frame update
    public void AddScore(int score)
    {

        if (die.HeartHealth == 0) 
        {
            ScoreCount = 0;
        }
        else
        {
            ScoreCount += score;
            ScoreText.text = ScoreCount.ToString();
        }

    }
}
