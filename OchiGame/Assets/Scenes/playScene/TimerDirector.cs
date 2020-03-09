using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerDirector : MonoBehaviour
{
    GameObject TimerValueText;
    private GameObject StageDataContainer;

    private float ElapsedTime = 0.0f;

    public int ElapsedTimeInAStage { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        TimerValueText = GameObject.Find("TimerValueText");
        StageDataContainer = GameObject.Find("StageDataContainer");
        ElapsedTimeInAStage = StageDataContainer.GetComponent<StageDataContainer>().StageLimitTime;

        TimerValueText.GetComponent<Text>().text = ElapsedTimeInAStage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームプレイが始まる前であれば以下のアイテム生成処理を無効化する。
        //FIXME:この条件文、プレイしているときにもずっと走っている
        //何とかプレイする前だけこの条件文を走らせたい。
        if (StageDataContainer.GetComponent<StageDataContainer>().GetBeforePlayStageBeginning())
        {
            return;
        }

        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > 1.0f)
        {
            ElapsedTime = 0;
            ElapsedTimeInAStage--;
            TimerValueText.GetComponent<Text>().text = ElapsedTimeInAStage.ToString();
        }
    }

   
}
