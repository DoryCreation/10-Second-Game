using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Movement : MonoBehaviour
{
    private Vector3 mOffset;
    //collects the z axis position of the game object
    private float mZCoord;
    //[SerializeField] private AudioSource leafRussle;
    public Vector3 currentPos;


    public int trolleyScore;

    void OnMouseDown()
    {
        //locking in the z axis position for the game object
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //mouse offset = game objects position in the world - mouse position in the world
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }


    private Vector3 GetMouseWorldPos()
    {
        //coordinates supplied by the mouses position, but doesn't include z axis
        Vector3 mousePoint = Input.mousePosition;
        //z axis position provided by the game object
        mousePoint.z = mZCoord;
        //combine them to world positions
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {

        //move the object to the position created above
        transform.position = GetMouseWorldPos() + mOffset;
    }

    void OnMouseUp()
    {

        //gameObject.transform.position = new Vector3(Mathf.Round(currentPos.x), Mathf.Round(currentPos.y), Mathf.Round(currentPos.z));
        //Vector3Int.RoundToInt(Vector3);
        Debug.Log("Drag ended!");
        //OnTriggerEnter();
    }

    /*void OnTriggerEnter(Collider Trolley)
    {
        if (Trolley.tag == "Trolley")
        {
            trolleyScore++;
        }
    }
    */
}

