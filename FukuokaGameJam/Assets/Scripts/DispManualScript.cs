using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispManualScript : MonoBehaviour
{
    [SerializeField] GameObject manualPanelObj;
    // Start is called before the first frame update
    void Start()
    {
        GManager.instance.SetTimeScale(0);
        manualPanelObj.GetComponent<RectTransform>().localPosition = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        manualPanelObj.SetActive(false);
        GManager.instance.SetTimeScale(1.0f);
    }


}
