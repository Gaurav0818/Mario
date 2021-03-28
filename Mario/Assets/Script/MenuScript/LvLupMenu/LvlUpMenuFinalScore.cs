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
        displayScore.text = FindObjectOfType<DDOL>().scoreDDOL.ToString("00000");
    }
}
