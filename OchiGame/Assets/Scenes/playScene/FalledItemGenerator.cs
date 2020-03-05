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

    private int[] ProbabilityList = 
    {
        80,
        10,
        5,
        5
    };

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
        int GeneratingIndex = CalculateProbabilistic(ProbabilityList);

        GameObject tmpGameObject = Instantiate(FallingItems[GeneratingIndex]) as GameObject;

       
        int xGeneratedArrow = Random.Range(-6, 7);
        tmpGameObject.transform.position = new Vector3(xGeneratedArrow, 5.5f, 0);
    }

    /// <summary>
    /// <para>引数で渡された確率のリスト(百分率)に従って数値を返す。 </para>
    /// <para>リストに10,80,10と指定されたら10％の確率で0を,80％で1,10％で2を返す。</para>
    /// <para>リストの数値の合計値は100である必要がある。</para>
    /// </summary>
    /// <param name="probabilityList"></param>
    /// <returns></returns>
    private int CalculateProbabilistic(int[] ProbabilityList)
    {
        int ReturnedIndex = 0;
        int RandomValue = Random.Range(1, 101);//101は含まない
        int MaxValue = 0;
        int MinValue = 1;

        foreach (int i in ProbabilityList)
        {
            MaxValue += i;
            if(MinValue <= RandomValue && RandomValue <= MaxValue)
            {
                break;
            }
            MinValue += i;
            ReturnedIndex++;
        }

        return ReturnedIndex;
    }
}
