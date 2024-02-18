using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage5 : MonoBehaviour
{
    private int objectCount;
    [SerializeField] Sprite[] Image;
    [SerializeField] GameObject Box;
    [SerializeField] Animator animator;
    [SerializeField] Sprite Image2;

    // アルファ値を設定するための変数
    [SerializeField] float alphaValue = 1f;

    [SerializeField] GameObject canvas;
    [SerializeField] AudioClip clear;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void button()
    {
        Invoke("loadscene", 2.0f);
        canvas.GetComponent<AudioSource>().enabled = false;
        gameObject.GetComponent<AudioSource>().PlayOneShot(clear);
        // ボックスのイメージを設定する
        SetImage(0);
        // アニメーションを再生する
        PlayAnimation();
    }
    

    public void button2()
    {
        // 正解のイメージを設定する
        SetImage(1);
    }

    public void button3()
    {
        SetImage(2);
    }

    public void button4()
    {
        SetImage(3);
    }

    public void button5()
    {
        SetImage(4);
    }

    // イメージを設定するメソッド
    void SetImage(int index)
    {
        // Boxがnullでないことを確認
        if (Box != null)
        {
            // イメージコンポーネントを取得
            Image imageComponent = Box.GetComponent<Image>();

            // BoxにImageがアタッチされていることを確認
            if (imageComponent != null)
            {
                // スプライトを設定
                imageComponent.sprite = Image[index];

                // カラーを取得してアルファ値を設定
                Color color = imageComponent.color;
                color.a = alphaValue; // アルファ値を設定
                imageComponent.color = color; // 設定したアルファ値を反映
            }
            else
            {
                Debug.LogWarning("BoxにImageがアタッチされていません。");
            }
        }
        else
        {
            Debug.LogWarning("Boxがnullです。");
        }
    }

    // アニメーションを再生するメソッド
    void PlayAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("PlayAnimationTrigger");
        }
        else
        {
            Debug.LogWarning("Animatorがアタッチされていません。");
        }
    }

    public void loadscene()
    {
        SceneManager.LoadScene("Stage6");
    }
}
