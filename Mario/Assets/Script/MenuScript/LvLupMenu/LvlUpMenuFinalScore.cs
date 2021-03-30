using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlUpMenuFinalScore : MonoBehaviour
{
    Text displayScore;
    private void Start()
    {
        displayScore = GetComponent<Text>();
        if (FindObjectOfType<DDOL>() != null)
        {
            float score = FindObjectOfType<DDOL>().scoreDDOL;
            float time = FindObjectOfType<DDOL>().timeDDOL;
            float maxtime = FindObjectOfType<DDOL>().maxTime;
            float FinalScore = score + (maxtime - time );

            displayScore.text = FinalScore.ToString("00000");

        }
        
    }
}
