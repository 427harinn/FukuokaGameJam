using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountScript : MonoBehaviour
{
    [SerializeField] GameObject[] destroyobj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        if(destroyobj != null)
        {
            for (int i = 0; i < destroyobj.Length; i++)
            {
                Destroy(destroyobj[i]);
            }
        }

        Destroy(gameObject);
    }
}
