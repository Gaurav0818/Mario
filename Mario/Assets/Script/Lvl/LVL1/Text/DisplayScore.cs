using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        scoreText.text = FindObjectOfType<Score>().score.ToString("00000");
    }
}
