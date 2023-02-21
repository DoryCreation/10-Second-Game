using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeletion : MonoBehaviour
{
    public int rowOne;
    public int rowTwo;


    void OnEnable()
    {
        EventManager.RowOneScoreEvent += RowOneDetection;
        EventManager.RowTwoScoreEvent += RowTwoDetection;
    }

    void OnDisable()
    {
        EventManager.RowOneScoreEvent -= RowOneDetection;
        EventManager.RowTwoScoreEvent -= RowTwoDetection;
    }

    void RowOneDetection()
    {
        rowOne++;
        if(rowOne > 3)
        {
            Debug.Log("deleting");
            EventManager.RowOneDeletionFunction();
            rowOne = 0;
        }
        
    }

    void RowTwoDetection()
    {
        rowTwo++;
        if (rowTwo > 3)
        {
            Debug.Log("deleting");
            EventManager.RowTwoDeletionFunction();
            rowTwo = 0;
        }

    }
}
