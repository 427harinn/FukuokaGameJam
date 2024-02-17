using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider bgmSlider;
    [SerializeField] Slider seSlider;

    void Start()
    {

        bgmSlider.value = GManager.instance.bgmVolume;
        seSlider.value = GManager.instance.seVolume;

        //ƒXƒ‰ƒCƒ_[‚ğ“®‚©‚µ‚½‚Ìˆ—‚ğ“o˜^
        bgmSlider.onValueChanged.AddListener(SetAudioMixerBGM);
        seSlider.onValueChanged.AddListener(SetAudioMixerSE);
    }

    //BGM
    public void SetAudioMixerBGM(float value)
    {
        //5’iŠK•â³
        value /= 5;
        //-80~0‚É•ÏŠ·
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //audioMixer‚É‘ã“ü
        audioMixer.SetFloat("BGM", volume);
        Debug.Log($"BGM:{volume}");
        GManager.instance.bgmVolume = (int)value;
    }

    //SE
    public void SetAudioMixerSE(float value)
    {
        //5’iŠK•â³
        value /= 5;
        //-80~0‚É•ÏŠ·
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //audioMixer‚É‘ã“ü
        audioMixer.SetFloat("SE", volume);
        Debug.Log($"SE:{volume}");
        GManager.instance.seVolume = (int)(value*5);
    }
}