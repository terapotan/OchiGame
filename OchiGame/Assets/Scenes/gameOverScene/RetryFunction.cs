using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryFunction : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
