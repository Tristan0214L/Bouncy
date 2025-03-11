using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //double
    //int
    //string
    //char
    //float
    //bool
    //DateTime

    //Global Variables
    [SerializeField]
    private bool MyBool = false;


    float MaxSize = 10f;
    float MinSize = 0.1f;
    bool Sizing = false;

/// <summary>
/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </T>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
       
    }
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
       gameObject.transform.


        gameObject.transform.Rotate(new Vector3(0f, 1.0f, 0.0f));

        if (Input.GetKey(KeyCode.Space)){
            Debug.Log("HI");

        }
        if (MyBool)
        {
        }
    }


}
