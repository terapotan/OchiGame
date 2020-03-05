using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalledItemGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    
    public void GenerateFalledItem()
    {
        GameObject tmpGameObject = Instantiate(ArrowPrefab) as GameObject;
        int xGeneratedArrow = Random.Range(-6, 7);
        tmpGameObject.transform.position = new Vector3(xGeneratedArrow, 5.5f, 0);
    }
}
