using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalledItemGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject StarPrefab;
    public GameObject SpeedUpPrefab;
    public GameObject SpeedDownPrefab;

    private GameObject[] FallingItems;

    public void Start()
    {
        FallingItems = new GameObject[]
        {
            ArrowPrefab,
            StarPrefab,
            SpeedUpPrefab,
            SpeedDownPrefab
        };
    }

    public void GenerateFalledItem()
    {
        int GeneratingIndex = Random.Range(0, 4);
        GameObject tmpGameObject = Instantiate(FallingItems[GeneratingIndex]) as GameObject;

       
        int xGeneratedArrow = Random.Range(-6, 7);
        tmpGameObject.transform.position = new Vector3(xGeneratedArrow, 5.5f, 0);
    }
}
