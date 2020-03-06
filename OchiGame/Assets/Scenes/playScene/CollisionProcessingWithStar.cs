using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProcessingWithStar : IPossibleToCollisionProcessWithDroid
{
    public void DoCollisionProcess()
    {
        Debug.Log("Star");
    }
}
