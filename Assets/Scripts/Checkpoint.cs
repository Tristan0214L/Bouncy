using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HELLO THIS IS HAPPENING");
        BallController temp = other.gameObject.GetComponent<BallController>();
        if(temp != null)
        {
            
            temp.ChangeCheckpoint(transform.position);
            //set players restart point
        }
    }
}
