using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    float deathTime;
    public bool StartDeathTime = false;

    private void Update()
    {
        if (StartDeathTime == true)
        {
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
