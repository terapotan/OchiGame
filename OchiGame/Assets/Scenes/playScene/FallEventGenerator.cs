using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEventGenerator : MonoBehaviour
{

    private const float CycleToGenerateArrow = 0.5f;
    private float ElapsedTime = 0.0f;
    private GameObject ItemGenerator;

    // Start is called before the first frame update
    void Start()
    {
        ItemGenerator = GameObject.Find("ItemGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if(ElapsedTime > CycleToGenerateArrow)
        {
            ElapsedTime = 0;
            ItemGenerator.GetComponent<FalledItemGenerator>().GenerateFalledItem();
        }

    }
}
