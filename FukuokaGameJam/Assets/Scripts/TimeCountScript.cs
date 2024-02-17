using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountScript : MonoBehaviour
{
    [SerializeField] GameObject resulePanel;
    Text _timeCountText;
    [SerializeField] float _countDown = 30;
    // Start is called before the first frame update
    void Start()
    {
        _timeCountText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _countDown -= Time.deltaTime;

        _timeCountText.text = ((int)Mathf.Ceil(_countDown)).ToString();

        if(_countDown < 0)
        {
            resulePanel.SetActive(true);
            GManager.instance.SetTimeScale(0);
        }


    }



}
