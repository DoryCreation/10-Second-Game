using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOneOne : MonoBehaviour
{
    public int rowOne;
    public int columnOne;

    void OnEnable()
    {
        EventManager.RowOneDeletionEvent += RowOneDeletion;
    }

    void OnDisable()
    {
        EventManager.RowOneDeletionEvent -= RowOneDeletion;
    }

    void OnTriggerEnter(Collider OneOne)
    {
        if (OneOne.tag == "1.1")
        {
            Debug.Log("1/1");
            rowOne++;
            columnOne++;
            EventManager.RowOneScoreFunction();
        }
    }

    void OnTriggerExit(Collider OneOne)
    {
        if (OneOne.tag == "1.1")
        {
            Debug.Log("-1/1");
            rowOne--;
            columnOne--;
        }
    }

    void RowOneDeletion()
    {
        if(rowOne > 0)
        {
            Destroy(gameObject);
        }
    }
}
