using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_PlayerScript : MonoBehaviour
{

    [Header("移動させたいスピード(X方向)")]
    [SerializeField] float moveSpeedX; //x軸移動速度

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionX; //反転する位置（この距離を進んだら折り返す）
    [SerializeField] float minReturnPositionX; //反転する位置（この距離を進んだら折り返す）

    [SerializeField] Stage1Script stage1;

    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (stage1.start)
        {
            Vector3 position = transform.position;
            position.x += moveSpeedX * Time.deltaTime;

            if(jump)
            {
                position.y += moveSpeedX * Time.deltaTime;
            }

            transform.position = position;
        }

    }

    public void onClicked_screen()
    {
        Debug.Log(transform.position.x);
        if (Mathf.Abs(4 - transform.position.x) < 0.5f) {
            jump = true;
        }
        
    }
}
