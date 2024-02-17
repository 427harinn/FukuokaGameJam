/*
 * オブジェクトを決められた範囲で往復移動させるコンポーネント
 * RigitBody2Dがついているオブジェクトには使えない
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kms_MoveRoundTripScript : MonoBehaviour
{
    [Header("移動させたいスピード(X方向)")]
    [SerializeField] float moveSpeedX; //x軸移動速度
    [Header("移動させたいスピード(Y方向)")]
    [SerializeField] float moveSpeedY; //y軸移動速度

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionX; //反転する位置（この距離を進んだら折り返す）
    [SerializeField] float minReturnPositionX; //反転する位置（この距離を進んだら折り返す）

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionY;
    [SerializeField] float minReturnPositionY;
    private string objName;

    public stage2_start stage2script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stage2script.start)
        {
            Vector3 position = transform.position;
            position.x += moveSpeedX * Time.deltaTime;
            position.y += moveSpeedY * Time.deltaTime;

            //Debug.Log("X: " + position.x + " Y: " + position.y);

            if (maxReturnPositionX < position.x || minReturnPositionX > position.x)
            {
                moveSpeedX *= -1;
            }
            if (maxReturnPositionY < position.y || minReturnPositionY > position.y)
            {
                moveSpeedY *= -1;
            }
            transform.position = position;
        }


    }
    public void button()
    {
        Destroy(gameObject);
    }

}
