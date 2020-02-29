using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClearControler : MonoBehaviour
{
    public GameObject TimerDirector;

    // Start is called before the first frame update
    void Start()
    {
        TimerDirector = GameObject.Find("TimerDirector");
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerDirector.GetComponent<TimerDirector>().ElapsedTimeInAStage < 0)
        {
            SceneManager.LoadScene("gameClear");
        }
    }
}
