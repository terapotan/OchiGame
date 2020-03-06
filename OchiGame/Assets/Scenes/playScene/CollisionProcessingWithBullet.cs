using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProcessingWithBullet : IPossibleToCollisionProcessWithDroid
{
    public void DoCollisionProcess()
    {
        Debug.Log("Bullet");
    }
}
