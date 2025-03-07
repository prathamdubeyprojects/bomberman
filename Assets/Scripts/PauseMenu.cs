using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
   
    public static bool isGamePaused=false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {

        if(isGamePaused){
            Resume();
        }else{
            Pause();
        }
        }
    }

   public void Pause()
    {
       pauseMenuUI.SetActive(true);
       Time.timeScale=0f;
       isGamePaused=true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        isGamePaused=false;


    }


    public void LoadMenu(){

    Time.timeScale=1f;
    SceneManager.LoadScene("MainMenu");

    }

    public void Restart(){
          Time.timeScale=1f;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         isGamePaused=false;
    }
}
