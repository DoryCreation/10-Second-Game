using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsystem : MonoBehaviour
{
    // Start is called before the first frame update


    private int score;
    public TMP_Text scoreCountText;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //assign point values to different sized objects
    //when an item is placed and colliders activated, add that items points to total
    //when an item is destroyed, remove points from total
    //display point total at the top of the screen

    void countScore()
    {
        score = score + 1;
        scoreCountText.text = "score " + score; 
    }



    void OnEnabled()
    {
        EventManager.ScoreEvent += countScore;
    }

    void OnDisable()
    {
        EventManager.ScoreEvent -= countScore;
    }

}
