using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    void OnEnable()
    {
        Timer.EndGame += EndScreen;
    }


    void OnDisable()
    {
        Timer.EndGame -= EndScreen;
    }


    void EndScreen()
    {
        Vector3 pos = transform.position;
        pos.y = 0f;
        transform.position = pos;
    }

    //when timer runs out, execute endgame
    //bring up end game screen
    //calculate total of points at the end
    //MAYBE have a custom good/meh/bad title depending on number of total points
}
