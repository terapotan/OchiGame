using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{

    public GameObject ArrowPrefab;
    private const float CycleToGenerateArrow = 0.5f;
    private float ElapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ElapsedTime += Time.deltaTime;

        if(ElapsedTime > CycleToGenerateArrow)
        {
            ElapsedTime = 0;
            GameObject tmpGameObject = Instantiate(ArrowPrefab) as GameObject;
            int xGeneratedArrow = Random.Range(-6, 7);
            tmpGameObject.transform.position = new Vector3(xGeneratedArrow, 8, 0);
        }

    }
}
