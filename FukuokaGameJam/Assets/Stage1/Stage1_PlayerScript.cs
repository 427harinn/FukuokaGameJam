using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_PlayerScript : MonoBehaviour
{
    int count = 0;
    [SerializeField] int clearCount = 10;
    [SerializeField] GameObject result;

    bool gameclear = false;

    [SerializeField] AudioClip stageBGM;
    [SerializeField] AudioClip clearSE;

    // Start is called before the first frame update
    void Start()
    {
        GManager.instance.PlayBGM(stageBGM);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameclear) return;

        if(Input.GetKeyDown(KeyCode.Comma)) 
        { 
            count++;
            if(count >= clearCount)
            {
                gameclear = true;
                GManager.instance.PlaySE(clearSE);

                //ƒNƒŠƒA‚µ‚½‚çŠÔ‚ğ~‚ß‚é
                GManager.instance.SetTimeScale(0);
                result.SetActive(true);
                result.GetComponent<RectTransform>().localPosition = Vector3.zero;
            }
        }


    }
}
