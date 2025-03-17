using Mono.Cecil;
using UnityEngine;

public class TowerBullet : MonoBehaviour
{
    [SerializeField]
    float speed = 0;
    int damage = 1000000;

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
    private void OnCollisionEnter(Collision collision)
    {
        //physics based
        if (collision.gameObject.GetComponent<BallController>() != null)
        {
            //we have collided with player
            BallController playerBallController = collision.gameObject.GetComponent<BallController>();
            playerBallController.ResetPosition();

        }

        //destroy
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        //logic based
        if (other.gameObject.CompareTag("Player"))
        {

            BallController playerBallController = other.gameObject.GetComponent<BallController>();
            playerBallController.ResetPosition();
            //we have collided with player

        }

        Destroy(gameObject);
    }
}
