using UnityEngine;

public class TurretScript : MonoBehaviour
{
    //where to spawn
    public Transform spawnLocation;

    //what to spawn
    public GameObject bulletPrefab;

    //
    public GameObject ObjectPool;

    //how often 
    public float maxTime = 1;

    private float currentTime;
    
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
        //rotate turret to look at player
       transform.LookAt(BallController.Instance.transform);

        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            //spawn bullet at position
            var go = Instantiate(bulletPrefab);

            //place in right spot
            go.transform.position = spawnLocation.position;
            go.transform.rotation = transform.rotation;

            currentTime = maxTime;

        }



    }
}
