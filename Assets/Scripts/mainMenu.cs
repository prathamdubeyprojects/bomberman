using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Diagnostics;

public class mainMenu : MonoBehaviour
{
    
    public void playButton(){
      
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
      PauseMenu.isGamePaused=false;
    }


    public void quitButton(){

        UnityEngine.Debug.Log("QUIT");
        Application.Quit();
    }
}
