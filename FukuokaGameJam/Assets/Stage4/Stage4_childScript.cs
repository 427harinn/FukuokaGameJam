using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage4_childScript : MonoBehaviour
{
    [Header("移動させたいスピード(X方向)")]
    [SerializeField] float moveSpeedX; //x軸移動速度

    [Header("反転させる位置(X方向)")]
    [SerializeField] float maxReturnPositionX; //反転する位置（この距離を進んだら折り返す）
    [SerializeField] float minReturnPositionX; //反転する位置（この距離を進んだら折り返す）

    int count;
    float timer;

    [SerializeField]Stage4_adultScript adultscript;

    [SerializeField] Stage4Script stage4;
    [SerializeField] Sprite clearbackImage;
    [SerializeField] GameObject backImage;
    [SerializeField] GameObject rainbackImage;
    [SerializeField] GameObject timerobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stage4.start) {
            count++;

            Vector3 position = transform.position;
            Vector3 localScale = transform.localScale;
            position.x += moveSpeedX * Time.deltaTime;

            //Debug.Log("X: " + position.x + " Y: " + position.y);
            if (maxReturnPositionX < position.x || minReturnPositionX > position.x)
            {
                moveSpeedX *= -1;
            }
            else if (count > Random.Range(100, 30000))
            {
                count = 0;
                moveSpeedX *= -1;
                localScale.x *= -1;
            }

            transform.position = position;
            transform.localScale = localScale;

            if (Mathf.Abs(adultscript.adultpositionX - transform.position.x) < 2f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
            }

            if (timer > 3 && !timerobj.GetComponent<Timerdestroy>().finish)
            {
                timerobj.SetActive(false);
                backImage.GetComponent<Image>().sprite = clearbackImage;
                backImage.transform.parent.GetComponent<AudioSource>().enabled = false;
                rainbackImage.SetActive(false);
                Invoke("loadscene",2f);
            }
        }

    }

    void loadscene()
    {
        SceneManager.LoadScene("Stage5");
    }


}
