using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    Transform Row1;

    [SerializeField]
    Transform Row2;

    public GameObject obstacle;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnStuff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStuff()
    {
        var go = Instantiate(obstacle);

        go.transform.position = Row1.position;
        go.transform.rotation = Row1.rotation;


        var go2 = Instantiate(obstacle);

        go2.transform.position = Row2.position;
        go2.transform.rotation = Row2.rotation;

        for(int i = 1; i <= 10; i++)
        {
            var goTemp1 = Instantiate(obstacle);

            goTemp1.transform.position = Row1.position;
            goTemp1.transform.position += new Vector3(5 * i, 0, 0);

            goTemp1.transform.rotation = Row1.rotation;


            var goTemp2 = Instantiate(obstacle);

            goTemp2.transform.position = Row2.position;
            goTemp2.transform.position += new Vector3(5 * i, 0, 0);

            goTemp2.transform.rotation = Row2.rotation;
        }
    }
}
