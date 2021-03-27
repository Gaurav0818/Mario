using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerWhenCollideWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag=="Enemy" && FindObjectOfType<KillEnemyWhenJumpOnTop>().Ename != other.gameObject.name)
        {
            gameObject.GetComponent<BasicPlayerMovement>().isDead = true;
            Debug.Log(other.gameObject.tag);
            Destroy(gameObject,0.5f);
        }

    }
     
}
