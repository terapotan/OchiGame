using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromStringToInstanceConverter
{
    private Dictionary<string, IPossibleToCollisionProcessWithDroid> InstancePairs;

    public FromStringToInstanceConverter()
    {
        InstancePairs["Arrow"] = new CollisionProcessingWithArrow();
    }

    public IPossibleToCollisionProcessWithDroid ToCollisionProcessInstance(string KeyString)
    {
        return InstancePairs[KeyString];
    }
}
