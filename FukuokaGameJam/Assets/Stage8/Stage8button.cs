using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage8button : MonoBehaviour
{
    [SerializeField] GameObject clear;
    [SerializeField] GameObject timer;

    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip clearaudio;

    bool playse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClicked_button()
    {
        clear.SetActive(true);
        Destroy(timer);
        Invoke("loadscene", 2.0f);

        if (!playse)
        {
            playse = true;
            audiosource.PlayOneShot(clearaudio);
        }
    }

    public void loadscene()
    {
        SceneManager.LoadScene("Stage9");
    }
}
