using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timerdestroy : MonoBehaviour
{
    public bool finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void worldstop()
    {
        finish = true;
        Invoke("timerdelete", 4.0f);
    }

    public void timerdelete()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
