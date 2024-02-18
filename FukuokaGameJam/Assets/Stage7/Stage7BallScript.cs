using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage7BallScript : MonoBehaviour
{
    [SerializeField] Stage7Script stage7;

    [SerializeField] GameObject pitcherobj;
    public Sprite pitched;

    public bool canBatting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stage7.start)
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
        }
    }

    public void mincircle()
    {
        canBatting = true;
    }

    public void maxcircle()
    {
        canBatting = false;
    }

    public void through()
    {
        pitcherobj.GetComponent<Image>().sprite = pitched;
    }
}
