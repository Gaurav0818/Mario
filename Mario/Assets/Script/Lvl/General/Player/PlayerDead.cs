using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public AudioSource playerDie;
    float deathTime;
    bool deathaudioPlayer = false; //TO PLAY DEATH AUDIO ONLY ONCE
    public bool StartDeathTime = false;

    private void Update()
    {
        if (StartDeathTime == true)
        {
            if (deathaudioPlayer == false)
            {
                playerDie.Play();
                deathaudioPlayer = true;
            }
            deathTime += Time.deltaTime;
            
            if (deathTime > 3f)
            {
                
                playerDead();
            }
        }
    }
    public void playerDead()
    {
        SceneManager.LoadScene("DeathMenu");
    }
}
