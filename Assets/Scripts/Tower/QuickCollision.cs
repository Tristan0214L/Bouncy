using UnityEngine;

public class QuickCollision : MonoBehaviour
{
    //public variables
    TowerScript parent;

    private void Start()
    {
        //parent = GetComponent<TowerScript>();
        parent = GetComponentInParent<TowerScript>();

    }
    //


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BallController>())
        {
            parent.OnDeadlyCollision();
        }

    }
}
