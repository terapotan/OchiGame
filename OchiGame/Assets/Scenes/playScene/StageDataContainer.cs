using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDataContainer : MonoBehaviour
{
    private bool IsBeforePlayStageBeginning = true;

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

}
