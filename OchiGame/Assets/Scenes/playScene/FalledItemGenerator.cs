using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalledItemGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject StarPrefab;
    public GameObject SpeedUpPrefab;
    public GameObject SpeedDownPrefab;
    public GameObject BulletPrefab;

    private GameObject[] FallingItems;
    private GameObject StageDataContainer;


    private int[] ProbabilityList;

    public void Start()
    {
        StageDataContainer = GameObject.Find("StageDataContainer");
        ProbabilityList = new int[5];

        //FIXME:どこかにも書いた気がするが、ここは値を一つずつ受け取るのではなく
        //構造体か何かで受け取ったほうがいいだろう。
        //ステージデータ保管クラスからの値の読み出し
        ProbabilityList[0] = StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallArrow;
        ProbabilityList[1] = StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallStar;
        ProbabilityList[2] = StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallSpeedUp;
        ProbabilityList[3] = StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallSpeedDown;
        ProbabilityList[4] = StageDataContainer.GetComponent<StageDataContainer>().ProbabilityFallBullet;


        FallingItems = new GameObject[]
        {
            ArrowPrefab,
            StarPrefab,
            SpeedUpPrefab,
            SpeedDownPrefab,
            BulletPrefab
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
    //TODO:後でこの関数が正常に動作するか試験する必要があるだろう。
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
