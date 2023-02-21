using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridTwoOne : MonoBehaviour
{
    public int rowTwo;
    public int columnOne;

    void OnEnable()
    {
        EventManager.RowTwoDeletionEvent += RowTwoDeletion;
    }

    void OnDisable()
    {
        EventManager.RowTwoDeletionEvent -= RowTwoDeletion;
    }

    void OnTriggerEnter(Collider TwoOne)
    {
        if (TwoOne.tag == "2.1")
        {
            Debug.Log("2/1");
            rowTwo++;
            columnOne++;
            EventManager.RowTwoScoreFunction();
        }
    }

    void OnTriggerExit(Collider TwoOne)
    {
        if (TwoOne.tag == "2.1")
        {
            Debug.Log("-2/1");
            rowTwo--;
            columnOne--;
        }
    }

    void RowTwoDeletion()
    {
        if (rowTwo > 0)
        {
            //gameObject.transform.position = new Vector3(10f, 10f, 0f);
            Destroy(gameObject);
        }
    }
}
