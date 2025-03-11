using UnityEngine;

public class TurretScript : MonoBehaviour
{
    /// <summary>
    /// Ball position
    /// shoots
    /// rotate
    /// </summary>
    /// 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //tags
        

    }

    // Update is called once per frame
    void Update()
    {
        
       transform.LookAt(BallController.Instance.transform);
    }
}
