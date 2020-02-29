using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToGameTitle : MonoBehaviour
{
    public void MoveToGameTitle()
    {
        SceneManager.LoadScene("gameTitle");
    }
}
