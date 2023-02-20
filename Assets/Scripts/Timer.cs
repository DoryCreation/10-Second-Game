using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TMP_Text timeText;

    public GameObject endScreen;

    // Update is called once per frame
    void start()
    {
        //starts timer on level start
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                /*
                 * this delta time measures time between frames in the game
                 * so the timer works nomater the speed is running.
                 *
                 * for more about it:
                 * https://medium.com/star-gazers/understanding-time-deltatime-6528a8c2b5c8
                 */
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out");
                timeRemaining = 0;
                timerIsRunning = false;
                endScreen.SetActive(true);
                EventManager.FinishFunction();
                /*
                 * stops timer once count reaches 0
                 * also sets timer to 0 for the text
                 * and freezes it so it doesn't keep going
                 */
            }
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
