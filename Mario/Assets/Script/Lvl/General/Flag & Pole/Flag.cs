using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public float flagGravity;
    public bool moveFlag = false;
    public Rigidbody2D rb;

    //CHECK FLAG AUDIO IN PLAYER ANIMATION CONTROL

    private void Update()
    {
        if (moveFlag == true)
        {
            rb.gravityScale = 1f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("HardTiles"))
        {
            rb.gravityScale = 0;
            moveFlag = false;
            FindObjectOfType<PlayerAnimationControl>().isFlag = false;
        }
    }
}
