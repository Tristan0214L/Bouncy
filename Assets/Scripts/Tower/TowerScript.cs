using UnityEngine;

public class TowerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDeadlyCollision()
    {
        
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello we have collided apparently?");
    }


    
}
