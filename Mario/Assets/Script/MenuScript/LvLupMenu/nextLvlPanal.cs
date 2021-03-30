using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLvlPanal : MonoBehaviour
{
    public GameObject nextLvl;
    public bool nextLvlactive = false;
    bool _nextLvl = false;

    public void Update()
    {
        if(nextLvlactive == false && _nextLvl==true)
        {
            nextLvl.SetActive(false);
        }
    }
    public void showNextLvlPanal()
    {
        _nextLvl = true;
        nextLvlactive = true;
        nextLvl.SetActive(true);
        Debug.Log("set true");

    }
}
