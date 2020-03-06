using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionProcessingWithArrow : IPossibleToCollisionProcessWithDroid
{
    public void DoCollisionProcess()
    {
        SceneManager.LoadScene("gameOver");
    }
}
