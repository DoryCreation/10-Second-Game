using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ScoreAddAction();
    public static event ScoreAddAction ScoreAddEvent;
    public static void ScoreAddFunction()
    {
        print("event triggered!");
        if (ScoreAddEvent != null)
        {
            ScoreAddEvent(); //triggers the event
        }
    }
    public delegate void ScoreRemoveAction();
    public static event ScoreRemoveAction ScoreRemoveEvent;
    public static void ScoreRemoveFunction()
    {
        print("event triggered!");
        if (ScoreRemoveEvent != null)
        {
            ScoreRemoveEvent(); //triggers the event
        }
    }

    public delegate void FinishAction();
    public static event FinishAction FinishEvent;
    public static void FinishFunction()
    {
        print("event triggered!");
        if (FinishEvent != null)
        {
            FinishEvent(); //triggers the event
        }
    }
}

