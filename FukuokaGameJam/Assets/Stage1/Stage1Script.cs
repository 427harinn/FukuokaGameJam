using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Script : MonoBehaviour
{
    float timer = 0;
    [SerializeField] AudioClip rain;
    [SerializeField] GameObject finishanim;

    public bool start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3 && !start)
        {
            finishanim.SetActive(true);
            start = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(rain);
        }
        if (start && !gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(rain);
        }
    }
}
