using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_start : MonoBehaviour
{
    float timer = 0;
    [SerializeField] AudioClip rain;
    

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
            start = true;
            gameObject.GetComponent<AudioSource>().PlayOneShot(rain);
        }
        if (start && !gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(rain);
        }
    }
}
