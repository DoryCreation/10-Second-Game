using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void ScoreAction();

    public static event ScoreAction ScoreEvent;

    public static void ScoreFunction()
    {

        print("event triggered!");

        if (ScoreEvent != null)
        {
            ScoreEvent(); //triggers the event
        }
    }

}
