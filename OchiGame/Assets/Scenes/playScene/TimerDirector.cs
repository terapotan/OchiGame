using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerDirector : MonoBehaviour
{
    GameObject TimerValueText;
    private float ElapsedTime = 0.0f;
    private int ElapsedTimeInStage = 100;//単位は秒

    // Start is called before the first frame update
    void Start()
    {
        TimerValueText = GameObject.Find("TimerValueText");
        TimerValueText.GetComponent<Text>().text = ElapsedTimeInStage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 1.0f)
        {
            ElapsedTime = 0;
            ElapsedTimeInStage--;
            TimerValueText.GetComponent<Text>().text = ElapsedTimeInStage.ToString();
        }
    }
}
