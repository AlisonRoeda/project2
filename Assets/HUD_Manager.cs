using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Manager : MonoBehaviour
{

    int score;

    public Text scoretext;

    // Use this for initialization
    void Start(){
        score = 0;
        scoretext.text = "crystal count: " + score;
    }

   
  void UpdateScore(int amount)
    {
        score = score + amount;
        scoretext.text = "crystal count: " + score;
    }
}

