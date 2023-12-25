using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour
{
   public Text ScoreText;

   
    // Update is called once per frame
    void Update()
    {
        ScoreText.text=Score.p.ToString();
    }
}
