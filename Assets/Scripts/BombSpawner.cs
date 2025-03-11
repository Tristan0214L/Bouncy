using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject bomb;

    [SerializeField]
    Transform spawnLocation;

    [SerializeField]
    public const float maxTime = 2.0f;
    float currentTime = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            Spawn();
            ResetTime();
        }
    }
    void ResetTime()
    {
        currentTime = maxTime;
    }
    void Spawn()
    {
        Debug.Log("Spawn called");

        //var go = Instantiate(bomb);
        //go.transform.position = spawnLocation.position;

        ObjectPool.Instance.SpawnObject(spawnLocation.position);









    }
}
