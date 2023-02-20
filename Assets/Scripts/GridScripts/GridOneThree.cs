using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOneThree : MonoBehaviour
{
    public int rowOne;
    public int columnThree;

    void OnEnable()
    {
        EventManager.RowOneDeletionEvent += RowOneDeletion;
    }

    void OnDisable()
    {
        EventManager.RowOneDeletionEvent -= RowOneDeletion;
    }

    void OnTriggerEnter(Collider OneThree)
    {
        if (OneThree.tag == "1.4")
        {
            Debug.Log("1/4");
            rowOne++;
            columnThree++;
            EventManager.RowOneScoreFunction();
        }
    }

    void OnTriggerExit(Collider OneThree)
    {
        if (OneThree.tag == "1.3")
        {
            Debug.Log("-1/3");
            rowOne--;
            columnThree--;
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
