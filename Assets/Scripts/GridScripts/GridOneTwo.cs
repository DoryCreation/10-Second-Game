using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOneTwo : MonoBehaviour
{
    public int rowOne;
    public int columnTwo;

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
        if (OneOne.tag == "1.2")
        {
            Debug.Log("1/2");
            rowOne++;
            columnTwo++;
            EventManager.RowOneScoreFunction();
        }
    }

    void OnTriggerExit(Collider OneOne)
    {
        if (OneOne.tag == "1.2")
        {
            Debug.Log("-1/2");
            rowOne--;
            columnTwo--;
        }
    }

    void RowOneDeletion()
    {
        if (rowOne > 0)
        {
            Destroy(gameObject);
        }
    }
}
