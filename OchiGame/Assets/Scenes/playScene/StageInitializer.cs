using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StageInitializer : MonoBehaviour
{
    private GameObject StageDataContainer;

    // Start is called before the first frame update
    void Start()
    {
        StageDataContainer = GameObject.Find("StageDataContainer");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StageDataContainer.GetComponent<StageDataContainer>().SetBeforePlayStageBeginning(false);
            GameObject.Find("PressAnyKeyText").GetComponent<Image>().enabled = false;
        }
    }
}
