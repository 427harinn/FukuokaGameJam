using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kms_ItemGetCountScript : MonoBehaviour
{
    private int itemGetCount = 0;

    [SerializeField] GameObject clearObj;
    [SerializeField] GameObject canvas;
    public AudioClip getclip;
    public AudioClip clearclip;

    bool clear = false;

    public GameObject yuge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(itemGetCount == 3 && !clear)
        {
            Invoke("loadscene", 3.0f);
            clear = true;
            yuge.SetActive(true);
            clearObj.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(clearclip);
            canvas.GetComponent<AudioSource>().enabled = false;
        }
    }
    public void button()
    {
        itemGetCount += 1;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(getclip);
    }

    void loadscene()
    {
        SceneManager.LoadScene("Stage3");
    }
}
