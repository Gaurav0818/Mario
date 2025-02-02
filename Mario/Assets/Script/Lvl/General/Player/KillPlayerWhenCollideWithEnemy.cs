﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerWhenCollideWithEnemy : MonoBehaviour
{
    
    public AudioSource mainAudio;
    public LayerMask plant;
    
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag=="Enemy" && FindObjectOfType<KillEnemyWhenJumpOnTop>().Ename != other.gameObject.name)
        {
            gameObject.GetComponent<BasicPlayerMovement>().isDead = true;
            Debug.Log(other.gameObject.tag);
            mainAudio.Stop();
            
            other.gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<BasicPlayerMovement>().enabled = false;
            FindObjectOfType<PlayerDead>().StartDeathTime = true;
            Destroy(gameObject, 3f);
            other.gameObject.GetComponent<EnemyMovement>().enabled = false;
            
        }


        if (other.gameObject.tag == "PlantEnemy" && FindObjectOfType<KillEnemyWhenJumpOnTop>().Ename != other.gameObject.name)
        {
            gameObject.GetComponent<BasicPlayerMovement>().isDead = true;
            Debug.Log(other.gameObject.tag);
            mainAudio.Stop();
            
            other.gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<BasicPlayerMovement>().enabled = false;
            FindObjectOfType<PlayerDead>().StartDeathTime = true;
            Destroy(gameObject, 3f);
            other.gameObject.GetComponent<PiranhaMovement>().enabled = false;
            other.gameObject.GetComponent<PiranhaMovement>().rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
     
}
