using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenuFinalScore : MonoBehaviour
{
    Text displayScore;

    private void Start()
    {
        displayScore = GetComponent<Text>();
        if (FindObjectOfType<DDOL>() != null) 
            displayScore.text = FindObjectOfType<DDOL>().scoreDDOL.ToString("00000");
    }
}
