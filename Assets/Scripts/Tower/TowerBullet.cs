using Mono.Cecil;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    [SerializeField]
    float speed = 0;
    int damage;

    private void Update()
    {
        //transform.position += new Vector3(speed, 0, 0); //manual method




        //get forward
        Vector3 forward = transform.forward;

        //never ever ever use float first
        Vector3 direction = forward * speed;

        //take our direction/speed and actually move our object
        transform.position += direction * Time.deltaTime;


    }
}
