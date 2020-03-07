using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


struct StageDataStruct
{
    public int ProbabilityFallArrow;
    public int ProbabilityFallStar;
    public int ProbabilityFallSpeedUp;
    public int ProbabilityFallSpeedDown;
    public int ProbabilityFallBullet;
    public int StageLimitTime;
    public float CycleToGenerateItems;
}


public class StageInitializer : MonoBehaviour
{
    private GameObject StageDataContainer;
    private StageDataStruct[] StageDataList;

    // Start is called before the first frame update
    void Start()
    {
        //0:EASY,1:NORMAL,2:HARD(PlayStageType)
        StageDataContainer = GameObject.Find("StageDataContainer");
        StageDataList = new StageDataStruct[3];

        //FIXME:コードにステージデータを直接書くのは望ましいとは言えない(というかコードの量がやばい)
        //ファイルにデータを置いて置き、それをロードする形にしたほうがいいだろう。
        
        //EasyStage
        StageDataList[0].ProbabilityFallArrow       = 0;
        StageDataList[0].ProbabilityFallStar        = 0;
        StageDataList[0].ProbabilityFallSpeedUp     = 50;
        StageDataList[0].ProbabilityFallSpeedDown   = 50;
        StageDataList[0].ProbabilityFallBullet      = 0;
        StageDataList[0].StageLimitTime             = 30;
        StageDataList[0].CycleToGenerateItems       = 0.5f;

        //NormalStage
        StageDataList[1].ProbabilityFallArrow       = 80;
        StageDataList[1].ProbabilityFallStar        = 10;
        StageDataList[1].ProbabilityFallSpeedUp     = 5;
        StageDataList[1].ProbabilityFallSpeedDown   = 4;
        StageDataList[1].ProbabilityFallBullet      = 1;
        StageDataList[1].StageLimitTime             = 30;
        StageDataList[1].CycleToGenerateItems       = 0.5f;

        //HardStage
        StageDataList[2].ProbabilityFallArrow       = 60;
        StageDataList[2].ProbabilityFallStar        = 20;
        StageDataList[2].ProbabilityFallSpeedUp     = 10;
        StageDataList[2].ProbabilityFallSpeedDown   = 5;
        StageDataList[2].ProbabilityFallBullet      = 5;
        StageDataList[2].StageLimitTime             = 40;
        StageDataList[2].CycleToGenerateItems       = 0.1f;

        //ステージデータセット
        StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallArrow 
            = StageDataList[StageMover.PlayStageType].ProbabilityFallArrow;
        StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallStar
            = StageDataList[StageMover.PlayStageType].ProbabilityFallStar;
        StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallSpeedUp
            = StageDataList[StageMover.PlayStageType].ProbabilityFallSpeedUp;
        StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallSpeedDown
            = StageDataList[StageMover.PlayStageType].ProbabilityFallSpeedDown;
        StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallBullet
            = StageDataList[StageMover.PlayStageType].ProbabilityFallBullet;
        StageDataContainer.GetComponent<StageDataContainer>().StageLimitTime
            = StageDataList[StageMover.PlayStageType].StageLimitTime;
        StageDataContainer.GetComponent<StageDataContainer>().SetCycleToGenerateItems(StageDataList[StageMover.PlayStageType].CycleToGenerateItems);

        GameObject.Find("SpeedDownIcon").GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StageDataContainer.GetComponent<StageDataContainer>().SetBeforePlayStageBeginning(false);
            GameObject.Find("PressAnyKeyText").GetComponent<Image>().enabled = false;
        }
    }
}