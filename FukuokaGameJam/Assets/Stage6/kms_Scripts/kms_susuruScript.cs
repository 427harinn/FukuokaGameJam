using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kms_susuruScript : MonoBehaviour
{
    //[SerializeField] Sprite[] newSprite;
    [SerializeField] GameObject [] ramenObj;
    private Image image;
    private int susuru = 0;

    [SerializeField] GameObject timer;

    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip clear;

    bool playse = false;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(0 <= susuru && susuru <= 10)
        {
            if(susuru%2 == 0)
            {
                ramenObj[0].SetActive(false);
                ramenObj[1].SetActive(true);
            } 
            else
            {
                ramenObj[0].SetActive(true);
                ramenObj[1].SetActive(false);
            }
            if(susuru == 10)
            {
                ramenObj[1].SetActive(false);
                ramenObj[3].SetActive(true);
            }
        }
        if(10 < susuru && susuru <= 20)
        {
            if (susuru % 2 == 0)
            {
                ramenObj[2].SetActive(false);
                ramenObj[3].SetActive(true);
            }
            else
            {
                ramenObj[2].SetActive(true);
                ramenObj[3].SetActive(false);
            }
            if (susuru == 20)
            {
                ramenObj[3].SetActive(false);
                ramenObj[5].SetActive(true);
            }
        }
        if (20 < susuru && susuru <= 35)
        {
            if (susuru % 2 == 0)
            {
                ramenObj[4].SetActive(false);
                ramenObj[5].SetActive(true);
            }
            else
            {
                ramenObj[4].SetActive(true);
                ramenObj[5].SetActive(false);
            }
        }
        if(susuru == 36)
        {
            if(!playse)
            {
                playse = true;
                audiosource.PlayOneShot(clear);
            }
           
            //ƒNƒŠƒA
            ramenObj[4].SetActive(false);
            ramenObj[6].SetActive(true);
            Destroy(timer);
            Invoke("loadscene", 2.0f);

        }
        //Max40‚­‚ç‚¢
        
    }

    public void button()
    {
        susuru += 1;
        Debug.Log("‚·‚·‚è‚Ü‚µ‚½ : " + susuru);
    }

    public void loadscene()
    {
        SceneManager.LoadScene("Stage7");
    }
}
