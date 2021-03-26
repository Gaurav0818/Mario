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

    public Rigidbody2D rb;
    public Animator animator;

    public AudioSource jumpAudio;

    void Start()
    {  
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        animator.SetFloat("Speed", 0.0f);
        ReadInput();
        Jump();
        ForAnimation();

    }

    
    void ForAnimation()
    {
        if (horizontal != 0 && rb.velocity.y == 0)
            animator.SetBool("IsRunning", true);
        else
            animator.SetBool("IsRunning", false);

        if (rb.velocity.y > 0)
            animator.SetBool("IsJumping", true);
        else
            animator.SetBool("IsJumping", false);

        if (rb.velocity.y < 0)
            animator.SetBool("IsFalling", true);
        else
            animator.SetBool("IsFalling", false);

        if (IsGrounded() == true)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsJumping", false);
        }
    }


    void ReadInput() {
        horizontal = 0;
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
        }
        else if (horizontal == -1)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
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
        jumpTimeCounter = jumpTime;
        
        if (IsGrounded() && (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W)))
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

    public LayerMask groundLayer;
    public float angle1;
    public float angle2;

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;
        Vector2 direction1 = new Vector2(Mathf.Cos(angle1 * Mathf.Deg2Rad), Mathf.Sin(angle1 * Mathf.Deg2Rad)).normalized;
        Vector2 direction2 = new Vector2(Mathf.Cos(angle2 * Mathf.Deg2Rad), Mathf.Sin(angle2 * Mathf.Deg2Rad)).normalized;
        
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        RaycastHit2D hit1 = Physics2D.Raycast(position, direction1 , distance, groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position, direction2 , distance, groundLayer);

        if (hit.collider != null )
        {
            return true;
        }else if (hit1.collider!=null)
        {
            return true;
        }else if (hit2.collider != null)
        {
            return true;
        }
        return false;
    }
}
