using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using common;

public class ArrowController : MonoBehaviour
{

    private float ScreenBottom;

    // Start is called before the first frame update
    void Start()
    {
        ExtendScreenFunction extendScreen = new ExtendScreenFunction();
        ScreenBottom = extendScreen.GetScreenBottom();

        Debug.Log(extendScreen.GetScreenBottom());
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < ScreenBottom)
        {
            Destroy(gameObject);
        }
    }
}
