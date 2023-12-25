using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   public AudioSource boom;
public GameObject sb;
public static int p;
    int health=1000;
    int sohits = 0;
    int dohits = 0;
    int mohits = 0;
    int score=110 + 200 + 160;
    void Start() {
        boom = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {
        boom.Play();
        if(other.gameObject.tag == "so"){
        health-=50; check();
        score-=10;
        sohits++;
     Debug.Log("You have bumped into a stationary obstacle "+sohits+ " number of times.");   
    }
    else if(other.gameObject.tag == "do"){
        dohits++;
        score-=50;
        health-=10;check();
     Debug.Log("You have bumped into a falling  obstacle "+dohits+ " number of times.");   
    }
    else if(other.gameObject.tag == "mo"){
        health-=20;check();
        score-=20;
        mohits++;
     Debug.Log("You have bumped into a moving  obstacle "+mohits+ " number of times.");   
    }
    else if (other.gameObject.tag=="win"){
        Debug.Log("You win!");
        score+=100;
        p=score;
        Time.timeScale=0f;
        sb.SetActive(true);
        


    }
    }
    public void check(){
        if(health<=0){

            Debug.Log("Health Zero");
            p=score;
            Time.timeScale=0f;
        sb.SetActive(true);
         

        }
    }
}
