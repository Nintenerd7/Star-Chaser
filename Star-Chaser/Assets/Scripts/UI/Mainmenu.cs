using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
  public void play()
    {   
        SceneManager.LoadScene(1);//loads level 
    }

    public void quit()
    {
        Application.Quit();//exits the game 
    }
}
