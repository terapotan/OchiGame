using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionProcessingWithSpeedDown : IPossibleToCollisionProcessWithDroid
{
    public void DoCollisionProcess()
    {
        GameObject.Find("android_kun").GetComponent<AndroidMotionControler>().slowDroidSpeed();
        GameObject.Find("android_kun").GetComponent<AndroidMotionControler>().PlayGettingItemSound();
        GameObject.Find("SpeedDownIcon").GetComponent<Image>().enabled = true;

    }
}
