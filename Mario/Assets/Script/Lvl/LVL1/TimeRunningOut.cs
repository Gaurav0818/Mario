using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRunningOut : MonoBehaviour
{
    public float warningTime;
    public AudioSource mainTune;
    public AudioSource warningAudio;
    public Text timedesplay; 
    private void Update()
    {
        if(warningTime > (FindObjectOfType<MaxTime>().maxTime - FindObjectOfType<GameTime>().time))
        {
            
            mainTune.Stop();
            if (!warningAudio.isPlaying)
                warningAudio.Play();
            timedesplay.color = Color.red;
        }
    }
}
