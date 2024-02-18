using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage7Button : MonoBehaviour
{
    [SerializeField] Stage7BallScript ballscript;

    [SerializeField] GameObject ballImage;
    [SerializeField] GameObject frameImage;

    [SerializeField] GameObject batterobj;

    public Sprite battinged;

    public AudioSource se;
    public AudioClip clearaudio;

    bool batted = false;

    [SerializeField] GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void onClicked_screenbutton()
    {
        batterobj.GetComponent<Image>().sprite = battinged;
        if (ballscript.canBatting && !batted)
        {
            se.PlayOneShot(clearaudio); 
            batted = true;
            Destroy(ballImage);
            Destroy(frameImage);
            Destroy(timer);
            Invoke("finish",2.0f);
        }
        batted = true;
        
    }

    public void finish()
    {
        SceneManager.LoadScene("Stage8");
    }
    
}
