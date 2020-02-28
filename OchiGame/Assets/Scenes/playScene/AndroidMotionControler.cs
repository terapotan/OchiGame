using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidMotionControler : MonoBehaviour
{
    private Rigidbody2D Rigid2D;

    private const float ANDROIDKUN_FORCE_SIZE = 50.0f;
    private const float MAX_SPEED_WALKING_ANDROIDKUN = 3.0f;
    private const int RIGHT = 1;
    private const int LEFT = -1;


    // Start is called before the first frame update
    void Start()
    {
        Rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int AndroidKunDirection = 0;


        if (Input.GetKey(KeyCode.RightArrow)) AndroidKunDirection = RIGHT;
        if (Input.GetKey(KeyCode.LeftArrow)) AndroidKunDirection = LEFT;

        float nowSpeedWalkingAndroidkun = Mathf.Abs(Rigid2D.velocity.x);

        if(nowSpeedWalkingAndroidkun < MAX_SPEED_WALKING_ANDROIDKUN)
        {
            Rigid2D.AddForce(transform.right * AndroidKunDirection * ANDROIDKUN_FORCE_SIZE);
        }
    }
}
