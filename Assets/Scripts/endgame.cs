using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(1);
    }

    //when timer runs out, execute endgame
    //bring up end game screen
    //calculate total of points at the end
    //MAYBE have a custom good/meh/bad title depending on number of total points
}
