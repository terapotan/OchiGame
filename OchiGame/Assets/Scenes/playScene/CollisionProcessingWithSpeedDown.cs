using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProcessingWithSpeedDown : IPossibleToCollisionProcessWithDroid
{
    public void DoCollisionProcess()
    {
        Debug.Log("SpeedDown");
    }
}
