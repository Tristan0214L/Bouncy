using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        InitiatePool();

    }

    //List of objects to store
    //Spawn stuff
    //Either static or dynamic size

    //where to spawn
    [SerializeField] GameObject spawnable;

    int sizeOfPool = 10;
    List<GameObject> objects = new List<GameObject>();


    public void SpawnObject(Vector3 position)
    {
        Debug.Log("Error 001");
        var go = GetObject();

        Debug.Log("Error 002");

        go.SetActive(true);
        Debug.Log("Error 003");

        go.transform.position = position;
        Debug.Log("Error 004");

    }
    GameObject GetObject()
    {
        Debug.Log("Error 0011");
        //loop through our list and check any inactive objects
        for(int i = 0;  i < objects.Count - 1; i++)
        {
            Debug.Log("Error 0012");

            if (!objects[i].activeInHierarchy)
            {
                Debug.Log("Error 0013");

                return objects[i];
            }
            
        }

        //if none of the above happens
        //increase our sizeOfPool, add new Instantiate to it
        sizeOfPool++;

        var go = Instantiate(spawnable);
        go.SetActive(false);
        objects.Add(go);
        return go;
    }
    void InitiatePool()
    {
        Debug.Log("Hey we actually initiated something");
        //should instantiate and spawn all 10 objects immediately.
        for (int i = 0; i < sizeOfPool; i++)
        {
            var go = Instantiate(spawnable);
            go.SetActive(false);
            objects.Add(go);

        }
    }



}
