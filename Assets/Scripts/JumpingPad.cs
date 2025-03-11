using Unity.VisualScripting;
using UnityEngine;

public class JumpingPad : MonoBehaviour
{
    public float jumpForce = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision);
    }
    void Bounce(Collision collision)
    {
        Debug.Log("We have collided");
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

    }

}
