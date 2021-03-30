using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocloseNectLvlPanal : MonoBehaviour
{
    private void Update()
    {
        if (FindObjectOfType<nextLvlPanal>().nextLvlactive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                FindObjectOfType<nextLvlPanal>().nextLvlactive = false;
            }
        }
    }
}
