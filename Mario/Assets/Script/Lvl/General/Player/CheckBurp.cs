using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBurp : MonoBehaviour
{
    public AudioSource burpAudio;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "MystryTiles" || other.tag == "HiddenScoreTiles")
        {
            burpAudio.Play();
        }
    }
}
