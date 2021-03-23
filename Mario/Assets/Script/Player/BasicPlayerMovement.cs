using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    

    public float jumpForce;
    public float jumpUpMagnituide;
    public float jumpDownMagnitude;
    public bool isGrounded;
    public float jumpTime;
    private float jumpTimeCounter;
    private bool isJump;

    private Vector3 movementForce;
    public float horizontal;

    public Rigidbody2D rb;
    public IsGrounded checkGrounded;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        ReadInput();
        Jump();
    }


    void ReadInput() {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (horizontal == -1)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


    void FixedUpdate()
    {
        Move();
        
        JumpGravity();
    }


    private void Move()
    {
        rb.transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);
    }


    private void Jump()
    {
        isGrounded = checkGrounded.isGrounded;
        /*if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rb.velocity = Vector2.up * jumpVelocity;
        }*/
        jumpTimeCounter = jumpTime;
        
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W)))
        {
            isJump = true;
            rb.velocity = Vector2.up * jumpForce;
            //rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (isJump == true && (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)))
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                //rb.AddForce(Vector2.up * jumpForce);
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
