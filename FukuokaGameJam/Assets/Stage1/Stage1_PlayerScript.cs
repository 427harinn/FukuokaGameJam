using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage1_PlayerScript : MonoBehaviour
{

    [Header("移動させたいスピード(X方向)")]
    [SerializeField] float moveSpeedX; //x軸移動速度
    [Header("移動させたいスピード(Y方向)")]
    [SerializeField] float moveSpeedY; //x軸移動速度

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionX; //反転する位置（この距離を進んだら折り返す）
    [SerializeField] float minReturnPositionX; //反転する位置（この距離を進んだら折り返す）

    [SerializeField] Stage1Script stage1;

    float iniY;
    bool jump = false;
    bool jumped = false;
    bool clear = false;
    bool playingse = false;

    public AudioClip jumpclip;
    public AudioClip clearclip;

    public Sprite walksprite;
    public Sprite jumpsprite;
    public Sprite clearsprite;

    [SerializeField] Timerdestroy timerscript;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        iniY = position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (stage1.start)
        {
            Vector3 position = transform.position;
            
            //Debug.Log(transform.position.y);
            if (jump)
            {
                if(position.y > iniY + 2) 
                {
                    moveSpeedY *= -1;
                }
                else if(position.y < iniY)
                {
                    this.gameObject.GetComponent<Image>().sprite = walksprite;
                    jump = false;
                }
                position.y += moveSpeedY * Time.deltaTime;

            }
            

            if(!jumped)
            {
                if(transform.position.x > -0.7f) 
                {
                    moveSpeedX = 0;
                    position.y += -(moveSpeedY + 1) * Time.deltaTime;
                }
            }
            if(transform.position.x > 5 && !timerscript.finish)
            {
                clear = true;
                moveSpeedX = 0;
            }
            position.x += moveSpeedX * Time.deltaTime;
            transform.position = position;

            if(clear && !playingse)
            {
                playingse = true;
                this.gameObject.GetComponent<Image>().sprite = clearsprite;
                this.gameObject.GetComponent<AudioSource>().PlayOneShot(clearclip);
                Invoke("loadscene",2.0f);
            }

            
        }

    }

    public void onClicked_screen()
    {
        if (-2.8f < transform.position.x && transform.position.x < -0.9f) {
            jump = true;
            jumped = true;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(jumpclip);
            this.gameObject.GetComponent<Image>().sprite = jumpsprite;
        }
        
    }

    void loadscene()
    {
        SceneManager.LoadScene("Stage2");
    }
}
