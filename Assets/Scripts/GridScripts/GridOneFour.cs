using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOneFour : MonoBehaviour
{
    public int rowOne;
    public int columnFour;

    void OnEnable()
    {
        EventManager.RowOneDeletionEvent += RowOneDeletion;
    }

    void OnDisable()
    {
        EventManager.RowOneDeletionEvent -= RowOneDeletion;
    }

    void OnTriggerEnter(Collider OneFour)
    {
        if (OneFour.tag == "1.4")
        {
            Debug.Log("1/4");
            rowOne++;
            columnFour++;
            EventManager.RowOneScoreFunction();
        }
    }

    void OnTriggerExit(Collider OneFour)
    {
        if (OneFour.tag == "1.4")
        {
            Debug.Log("-1/4");
            rowOne--;
            columnFour--;
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
