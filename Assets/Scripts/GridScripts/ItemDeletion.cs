using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDeletion : MonoBehaviour
{
    public int rowOne;


    void OnEnable()
    {
        EventManager.RowOneScoreEvent += RowOneDetection;
    }

    void OnDisable()
    {
        EventManager.RowOneScoreEvent -= RowOneDetection;
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
}
