using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBgmScript : MonoBehaviour
{
    [SerializeField] AudioClip bgm;
    // Start is called before the first frame update
    void Start()
    {
        GManager.instance.PlayBGM(bgm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
