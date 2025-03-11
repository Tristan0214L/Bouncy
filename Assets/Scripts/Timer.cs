
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    float currentTime;

    bool isRunning = false;


    [SerializeField] TextMeshProUGUI outputTime;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartTimer();
        UnityEngine.Random.Range(0, 2);

    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            currentTime += Time.deltaTime;
            VisualUpdate();

        }


    }
    void StopTimer()
    {
        isRunning = false;
    }
    void StartTimer()
    {
        currentTime = 0.0f;
        isRunning = true;
    }
    void VisualUpdate()
    {
        outputTime.text = currentTime.ToString();
    }
}
