using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4_adultScript : MonoBehaviour
{
    [Header("移動させたいスピード(X方向)")]
    [SerializeField] float moveSpeedX; //x軸移動速度

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionX; //反転する位置（この距離を進んだら折り返す）
    [SerializeField] float minReturnPositionX; //反転する位置（この距離を進んだら折り返す）

    public float adultpositionX;
    [SerializeField] Stage4Script stage4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stage4.start) {
            Vector3 position = transform.position;
            position.x += moveSpeedX * Time.deltaTime;

            //Debug.Log("X: " + position.x + " Y: " + position.y);

            if (maxReturnPositionX < position.x || minReturnPositionX > position.x)
            {
                moveSpeedX *= -1;
            }

            transform.position = position;
            adultpositionX = position.x;
        }

    }

    public void onClicked_directionbutton()
    {
        moveSpeedX *= -1;
    }


}
