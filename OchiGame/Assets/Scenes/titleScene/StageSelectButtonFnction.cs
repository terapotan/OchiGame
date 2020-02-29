using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageSelectButtonFnction : MonoBehaviour
{
    public void MoveStageSelectScene()
    {
        SceneManager.LoadScene("stageSelect");
    }
}
