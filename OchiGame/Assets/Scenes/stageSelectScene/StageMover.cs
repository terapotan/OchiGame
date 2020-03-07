using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageMover : MonoBehaviour
{
    /// <summary>
    /// <para>読み込むステージデータの種類(EASY,NORMAL,HARD)</para>
    /// FIXME:将来的にこの変数がなくとも動作するようにせよ。
    /// </summary>
    public static int PlayStageType = -1;


    public void MoveEasyStage()
    {
        PlayStageType = 0;
        SceneManager.LoadScene("playScene");
    }

    public void MoveNormalStage()
    {
        PlayStageType = 1;
        SceneManager.LoadScene("playScene");
    }

    public void MoveHardStage()
    {
        PlayStageType = 2;
        SceneManager.LoadScene("playScene");
    }
}
