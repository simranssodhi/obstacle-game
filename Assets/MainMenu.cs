using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
 public GameObject rules;
 public GameObject mm;
  
    public void PlayGame() {  
       // Debug.Log("HI!");
        SceneManager.LoadScene("GameScene");  
        
    }
    public void QuitGame() {  
        Debug.Log("QUIT");  
        // Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }  
     public void RuleBook() {  
       // Debug.Log("HI!");
       mm.SetActive(false);
        rules.SetActive(true);
        
    }
    public void OpenMainMenu() {  
       // Debug.Log("HI!");
        mm.SetActive(true);
        rules.SetActive(false);
        
    }
    


    
          
  
}


