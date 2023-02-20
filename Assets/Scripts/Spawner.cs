using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    private bool spawnerOn = false;
    void Start()
    {
        Instantiate(object1);
        Instantiate(object2);
        Instantiate(object3);
        Instantiate(object4);
        spawnerOn = true;
        StartCoroutine(SelectAndSpawnGameObject());
    }

    IEnumerator SelectAndSpawnGameObject()
    {
        while (spawnerOn == true)
        {
            yield return new WaitForSeconds(2f);
            int randomItem = Random.Range(0,4);

            if (randomItem == 0)
            {
                Instantiate(object1);
            }
            if (randomItem == 1)
            {
                Instantiate(object2);
            }
            if (randomItem == 2)
            {
                Instantiate(object3);
            }
            if (randomItem == 3)
            {
                Instantiate(object4);
            }
        }

    }

    void DisableSpawn()
    {
        spawnerOn = false;
    }

    void OnEnable()
    {
        EventManager.FinishEvent += DisableSpawn;
    }
    void OnDisable()
    {
        EventManager.FinishEvent -= DisableSpawn;
    }
}
