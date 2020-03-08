using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataContainer : MonoBehaviour
{
    private bool IsBeforePlayStageBeginning = true;

    //FIXME:以降の変数は全てpublicにしている。StageIntializerクラスからアクセスできるようにするためだ。
    //ただこれが設計上望ましいこととは思えない。時間がないのでひとまずこのままにするが、将来的には
    //読み出し専用に出来るようにするべきである。

    //FIXME:現在確率の値は一つ一つ渡されるようになっている。
    //これらの値は一気に渡されるものであるから、構造体か配列か何かにまとめたほうがいいだろう。

    public int ProbabilityFallArrow;
    public int ProbabilityFallStar;
    public int ProbabilityFallSpeedUp;
    public int ProbabilityFallSpeedDown;
    public int ProbabilityFallBullet;

    public int StageLimitTime;
    private float CycleToGenerateItems;//???:なぜかは分からないがここをprivateにすると正常に動作した。謎である。エラーも出てないし…

    public bool GetBeforePlayStageBeginning()
    {
        return IsBeforePlayStageBeginning;
    }

    //FIXME:このようにしてしまうと変数にpublicをつけているのと変わりない。
    //ある特定のクラスからのみアクセスできるようにするか、根本的に設計を変える必要があるだろう。
    public void SetBeforePlayStageBeginning(bool SetValue)
    {
        IsBeforePlayStageBeginning = SetValue;
    }



    public void SetCycleToGenerateItems(float SetValue)
    {
        CycleToGenerateItems = SetValue;
        GameObject.Find("FallEventGenerator").GetComponent<FallEventGenerator>().SetCycleToGenerateArrow(this.CycleToGenerateItems);
    }
}
