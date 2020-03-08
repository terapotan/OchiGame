using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEventGenerator : MonoBehaviour
{

    private float CycleToGenerateArrow;
    private float ElapsedTime = 0.0f;
    private GameObject ItemGenerator;
    private GameObject StageDataContainer;


    // Start is called before the first frame update
    void Start()
    {
        ItemGenerator = GameObject.Find("ItemGenerator");
        StageDataContainer = GameObject.Find("StageDataContainer");
    }

    // Update is called once per frame
    void Update()
    {
        if (StageDataContainer.GetComponent<StageDataContainer>().GetBeforePlayStageBeginning())
        {
            return;
        }

        ElapsedTime += Time.deltaTime;

        if (ElapsedTime > CycleToGenerateArrow)
        {
            ElapsedTime = 0;
            ItemGenerator.GetComponent<FalledItemGenerator>().GenerateFalledItem();
        }

    }

    public void SetCycleToGenerateArrow(float SetValue)
    {
        CycleToGenerateArrow = SetValue;
    }
}
