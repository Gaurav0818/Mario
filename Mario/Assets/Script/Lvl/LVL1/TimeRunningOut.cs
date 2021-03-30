using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRunningOut : MonoBehaviour
{
    public float warningTime;
    public AudioSource mainTune;
    public AudioSource warningAudio;
    private void Update()
    {
        if(warningTime > (FindObjectOfType<MaxTime>().maxTime - FindObjectOfType<GameTime>().time))
        {
            
            mainTune.Stop();
            if (!warningAudio.isPlaying)
                warningAudio.Play();
        }
    }
}
