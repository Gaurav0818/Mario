using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    
    public float jumpForce;
    public float jumpUpMagnituide;
    public float jumpDownMagnitude;
    public float distanceFromGround;

    public float jumpTime;
    private float jumpTimeCounter;
    private bool isJump;

    private Vector3 movementForce;
    public float horizontal;

    public bool isDead;

    public Rigidbody2D rb;
    

    public AudioSource jumpAudio;

    void Start()
    {
        isDead = false;
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
        ReadInput();
        Jump();

    }

    void ReadInput() {
        horizontal = 0;
        horizontal = Input.GetAxis("Horizontal");  
    }


    void FixedUpdate()
    {
        Move();   
        JumpGravity();
    }


    private void Move()
    {
        if (horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (horizontal == -1)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        rb.transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);
        
    }


    private void Jump()
    {
        jumpTimeCounter = jumpTime;
        
        if (FindObjectOfType<CheckGround>().IsGrounded() && (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W)))
        {
            isJump = true;
            rb.velocity = Vector2.up * jumpForce;
            jumpAudio.Play();
            
        }
        if (isJump == true && (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)))
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            isJump = false;
        }
      
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJump = false;
        }
    }


    private void JumpGravity()
    {
        if (rb.velocity.y > 0)
        {
            rb.gravityScale = jumpUpMagnituide;
        }
        if (rb.velocity.y < 0)
        {
            rb.gravityScale = jumpDownMagnitude;
        }
    }

    
}
