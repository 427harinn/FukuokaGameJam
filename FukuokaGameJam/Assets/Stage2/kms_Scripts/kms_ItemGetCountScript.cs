using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kms_ItemGetCountScript : MonoBehaviour
{
    private int itemGetCount = 0;

    [SerializeField] GameObject clearObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(itemGetCount == 3)
        {
            clearObj.SetActive(true);
        }
    }
    public void button()
    {
        itemGetCount += 1;

    }
}
