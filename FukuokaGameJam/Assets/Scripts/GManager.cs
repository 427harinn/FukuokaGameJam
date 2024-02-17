using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;


    AudioSource bgmAudioSource;
    AudioSource seAudioSource;
    AudioSource seAudioSource2;

    public int bgmVolume = 1;
    public int seVolume = 1;

    //public String name;
    //[SerializeField] int a;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }


        AudioMixer amix = Resources.Load("GameAudio") as AudioMixer;

        bgmAudioSource = instance.gameObject.AddComponent<AudioSource>();
        bgmAudioSource.outputAudioMixerGroup = amix.FindMatchingGroups("BGM")[0];
        bgmAudioSource.loop = true;


        seAudioSource = instance.gameObject.AddComponent<AudioSource>();
        seAudioSource.outputAudioMixerGroup = amix.FindMatchingGroups("SE")[0];

        seAudioSource2 = instance.gameObject.AddComponent<AudioSource>();
        seAudioSource2.outputAudioMixerGroup = amix.FindMatchingGroups("SE")[0];
    }


    public void SetTimeScale(float t)
    {
        Time.timeScale = t;
    }

    public void PlayBGM(AudioClip audioClip)
    {
        bgmAudioSource.clip = audioClip;
        bgmAudioSource.Play();
    }

    public void PlaySE(AudioClip audioClip)
    {
        seAudioSource.PlayOneShot(audioClip);
    }

}