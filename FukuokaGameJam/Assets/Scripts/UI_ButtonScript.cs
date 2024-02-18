using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_ButtonScript : MonoBehaviour
{
    [SerializeField] AudioClip titleBGM;
    [SerializeField] AudioClip settingsBGM;
    [SerializeField] AudioClip selectBGM;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TitleButton()
    {
        GManager.instance.PlayBGM(titleBGM);
        SceneManager.LoadScene("TitleScene");
    }

    public void StageSelectButton()
    {
        SceneManager.LoadScene("StageSelectScene");
    }

    public void CreditSceneButton()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void Stage1Button()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2Button()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void SettingButton()
    {
        SceneManager.LoadScene("SettingScene");
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
