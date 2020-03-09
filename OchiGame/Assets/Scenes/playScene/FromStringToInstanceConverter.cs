using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FromStringToInstanceConverter
{
    private Dictionary<string, IPossibleToCollisionProcessWithDroid> InstancePairs;

    public FromStringToInstanceConverter()
    {
        InstancePairs               = new Dictionary<string, IPossibleToCollisionProcessWithDroid>();

        InstancePairs["Arrow"]      = new CollisionProcessingWithArrow();
        InstancePairs["SpeedUp"]    = new CollisionProcessingWithSpeedUp();
        InstancePairs["SpeedDown"]  = new CollisionProcessingWithSpeedDown();
        InstancePairs["Star"]       = new CollisionProcessingWithStar();
        InstancePairs["Bullet"]     = new CollisionProcessingWithBullet();
    }

    /// <summary>
    /// <para>この関数はある文字列で処理を分岐させる場合に用いる。</para>
    /// <para>"Arrow"が与えられた時Arrowクラスの実体を返したいときなど。</para>
    /// <para>与えられた文字列に対する実体が割り当てられていない時nullを返す。</para>
    /// </summary>
    /// <param name="KeyString"></param>
    /// <returns></returns>
    public IPossibleToCollisionProcessWithDroid ToCollisionProcessInstance(string KeyString)
    {
        IPossibleToCollisionProcessWithDroid RetInstance;
        try
        {
            RetInstance = InstancePairs[KeyString];
        }
        catch (KeyNotFoundException)
        {
            RetInstance = null;
        }
        
        return RetInstance;
        
    }
}
