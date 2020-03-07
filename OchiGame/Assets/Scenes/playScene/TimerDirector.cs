using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerDirector : MonoBehaviour
{
    GameObject TimerValueText;
    private GameObject StageDataContainer;
    private float ElapsedTime = 0.0f;
    private int ElapsedTimeInStage = 15;//単位は秒
    public int ElapsedTimeInAStage
    {
        get
        {
            return ElapsedTimeInStage;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        TimerValueText = GameObject.Find("TimerValueText");
        StageDataContainer = GameObject.Find("StageDataContainer");

        TimerValueText.GetComponent<Text>().text = ElapsedTimeInStage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (StageDataContainer.GetComponent<StageDataContainer>().GetBeforePlayStageBeginning())
        {
            return;
        }

        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 1.0f)
        {
            ElapsedTime = 0;
            ElapsedTimeInStage--;
            TimerValueText.GetComponent<Text>().text = ElapsedTimeInStage.ToString();
        }
    }

   
}
