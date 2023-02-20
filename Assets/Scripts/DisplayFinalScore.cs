using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayFinalScore : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //access score from pointsystem  script and display it
        scoreText.text = pointsystem.score + " POINTS!";
    }
}
