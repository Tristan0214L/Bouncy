using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public void OnDeadlyCollision()
    {
        
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello we have collided apparently?");
    }


    
}
