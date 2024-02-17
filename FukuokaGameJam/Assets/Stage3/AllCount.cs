using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllCount : MonoBehaviour
{
    private int allCount = 3;
    public Animator animationComponent;

    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip audioclip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void allcount()
    {
        
        allCount--;
        audio.PlayOneShot(audioclip);

        if (allCount == 0)
        {
            
            UnityEngine.Debug.Log(allCount);
                //UnityEngine.Debug.Log(allCount);
            animationComponent.enabled = true;
            Invoke("loadscene",2.0f);

        }
    }

    void loadscene()
    {
        SceneManager.LoadScene("Stage4");
    }
}
