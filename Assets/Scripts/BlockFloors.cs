using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockFloors : MonoBehaviour
{
    public static BlockFloors instance;
    public int lvl2=1;
    public int lvl3=1;
    public Button blvl2;
    public Button blvl3;

    private void Start()
    {
        lvl2 = PlayerPrefs.GetInt("floor1", 1);
        if(lvl2 == 1)
        {
            blvl2.gameObject.SetActive(false);
            //blvl2.interactable = false;
        }
        else if(lvl2 == 0)
        {
            blvl2.gameObject.SetActive(true);
            //blvl2.interactable = true;
        }
        
        lvl3 = PlayerPrefs.GetInt("floor2", 1);
        if(lvl3 == 1)
        {
            blvl3.gameObject.SetActive(false);
        }
        else if(lvl3 == 0)
        {
            blvl3.gameObject.SetActive(true);
        }
        

    }
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    

}
