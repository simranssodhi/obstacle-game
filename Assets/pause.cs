using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    
    public static bool isPause = false;
    public GameObject pauseUI;
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPause){
                Resume();

            }
            else{
                Pause();
            }
        }
        

    }
    public void Pause(){
        pauseUI.SetActive(true);    
        Time.timeScale=0f;
        isPause = true;

    }
    public void Resume(){
        pauseUI.SetActive(false);    
        Time.timeScale=1f;
        isPause = false;

    }

    public void LoadMenu()
    {
      Time.timeScale=1f;
      SceneManager.LoadScene("MainMenu");
    }
    public void Quit(){
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;

    }
    public void Restart(){
        Time.timeScale=1f;
      SceneManager.LoadScene("GameScene");

    }
	

}

  