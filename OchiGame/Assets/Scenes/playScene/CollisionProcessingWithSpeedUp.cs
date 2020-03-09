using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionProcessingWithSpeedUp : IPossibleToCollisionProcessWithDroid
{

    public void DoCollisionProcess()
    {
        GameObject.Find("android_kun").GetComponent<AndroidMotionControler>().ReturnToOriginalDroidSpeed();
        GameObject.Find("android_kun").GetComponent<AndroidMotionControler>().PlayGettingItemSound();
        GameObject.Find("SpeedDownIcon").GetComponent<Image>().enabled = false;
    }
}
