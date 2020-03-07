using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidMotionControler : MonoBehaviour
{
    private Rigidbody2D Rigid2D;
    private FromStringToInstanceConverter InstanceConverter;

    private const float ANDROIDKUN_FORCE_SIZE = 19.8f;
    private float AndroidKunForceSize = ANDROIDKUN_FORCE_SIZE;
    
    private const float ANDROIDKUN_FORCE_SIZE_DURING_JUMP = 5.0f;

    private const float MAX_SPEED_WALKING_ANDROIDKUN = 6.5f;
    private float MaxSpeedWalkingAndroidKun = MAX_SPEED_WALKING_ANDROIDKUN;

    private const float ANDROIDKUN_JUMPFORCE_SIZE = 280.0f;

    private float ANDROIDKUN_INITIAL_Y_POSITION = -2.5f;

    private bool IsDuringJump = false;

    private const int RIGHT = 1;
    private const int LEFT = -1;

    private GameObject StageDataContainer;

    // Start is called before the first frame update
    void Start()
    {
        Rigid2D = GetComponent<Rigidbody2D>();
        InstanceConverter = new FromStringToInstanceConverter();

        StageDataContainer = GameObject.Find("StageDataContainer");

        //ANDROIDKUN_INITIAL_Y_POSITION = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームプレイが始まる前であれば以下の移動処理を無効化する。
        //FIXME:この条件文、プレイしているときにもずっと走っている
        //何とかプレイする前だけこの条件文を走らせたい。
        if (StageDataContainer.GetComponent<StageDataContainer>().GetBeforePlayStageBeginning())
        {
            return;
        }
        //FIXME:if文だらけで汚いコードだが、完成まで時間がない
        //とりあえず今回はこれ以上ここはいじらないと思うので
        //そのままにしておく。もしここを変更するときがあったら
        //その時こそリファクタリングしよう。
        int AndroidKunDirection = 0;

        if(transform.position.y >= ANDROIDKUN_INITIAL_Y_POSITION)
        {
            IsDuringJump = true;
        } else
        {
            AndroidKunForceSize = ANDROIDKUN_FORCE_SIZE;
            IsDuringJump = false;
        }
        

        if (Input.GetKey(KeyCode.RightArrow)) AndroidKunDirection = RIGHT;
        if (Input.GetKey(KeyCode.LeftArrow)) AndroidKunDirection = LEFT;

        if (Input.GetKeyDown(KeyCode.Space) && !IsDuringJump) Rigid2D.AddForce(transform.up * ANDROIDKUN_JUMPFORCE_SIZE);
     

        float nowSpeedWalkingAndroidkun = Mathf.Abs(Rigid2D.velocity.x + Rigid2D.velocity.y);

        if(nowSpeedWalkingAndroidkun < MaxSpeedWalkingAndroidKun)
        {
            if (IsDuringJump)
            {
                AndroidKunForceSize = ANDROIDKUN_FORCE_SIZE_DURING_JUMP;
            }

            Rigid2D.AddForce(transform.right * AndroidKunDirection * AndroidKunForceSize);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string GameObjectTag = collision.gameObject.tag;

        if (GameObjectTag != "Untagged")
        {
            Destroy(collision.gameObject);
        }

        IPossibleToCollisionProcessWithDroid processWithDroid = InstanceConverter.ToCollisionProcessInstance(GameObjectTag);
        processWithDroid?.DoCollisionProcess();
    }

    public void slowDroidSpeed()
    {
        MaxSpeedWalkingAndroidKun = MAX_SPEED_WALKING_ANDROIDKUN * 0.5f;
    }

    public void ReturnToOriginalDroidSpeed()
    {
        MaxSpeedWalkingAndroidKun = MAX_SPEED_WALKING_ANDROIDKUN;
    }
}
