using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using common;

public class ArrowController : MonoBehaviour
{
    public GameObject ArrowPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ExtendScreenFunction extendScreen = new ExtendScreenFunction();
        Debug.Log(extendScreen.GetScreenBottom());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
