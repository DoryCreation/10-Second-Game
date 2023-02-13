using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetect : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        EventManager.ScoreAddFunction();
    }
    void OnTriggerExit(Collider col)
    {
        EventManager.ScoreRemoveFunction();
    }
}
