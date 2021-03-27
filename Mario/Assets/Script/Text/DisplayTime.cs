using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public Text timeText;
    private void Update()
    {
        timeText.text = (FindObjectOfType<GameTime>().time*10).ToString("00000");   
    }
}
