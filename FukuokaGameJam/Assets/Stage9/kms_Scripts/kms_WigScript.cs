using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kms_WigScript : MonoBehaviour
{
    [SerializeField] GameObject[] wigObj;
    private Image image;
    private int hageCount = 0;

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
        if (0 <= hageCount && hageCount <= 10)
        {
            if (hageCount % 2 == 0)
            {
                wigObj[0].SetActive(false);
                wigObj[1].SetActive(true);
            }
            else
            {
                wigObj[0].SetActive(true);
                wigObj[1].SetActive(false);
            }
            if (hageCount == 10)
            {
                wigObj[1].SetActive(false);
                wigObj[3].SetActive(true);
            }
        }
        if (10 < hageCount && hageCount <= 20)
        {
            if (hageCount % 2 == 0)
            {
                wigObj[2].SetActive(false);
                wigObj[3].SetActive(true);
            }
            else
            {
                wigObj[2].SetActive(true);
                wigObj[3].SetActive(false);
            }
            if (hageCount == 20)
            {
                wigObj[3].SetActive(false);
                wigObj[5].SetActive(true);
            }
        }
        if (20 < hageCount && hageCount <= 35)
        {
            if (hageCount % 2 == 0)
            {
                wigObj[4].SetActive(false);
                wigObj[5].SetActive(true);
            }
            else
            {
                wigObj[4].SetActive(true);
                wigObj[5].SetActive(false);
            }
        }
        if (hageCount == 36)
        {
            if (!playse)
            {
                playse = true;
                audiosource.PlayOneShot(clear);
            }
            wigObj[4].SetActive(false);
            wigObj[7].SetActive(true);
            wigObj[8].SetActive(true);

            Destroy(timer);
            Invoke("loadscene", 2.0f);

        }
        


    }

    public void Button()
    {
        hageCount += 1;
        Debug.Log("hage : " + hageCount);
    }
    public void loadscene()
    {
        SceneManager.LoadScene("ClearScene");
    }
}
