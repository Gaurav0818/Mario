using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlOver : MonoBehaviour
{
    AudioSource lvlupAudio;
    public void lvlUp()
    {
        lvlupAudio = GameObject.Find("LvlOverAudio").GetComponent<AudioSource>();
        lvlupAudio.Play();
        SceneManager.LoadScene("LvlupMenu");
    }
}
