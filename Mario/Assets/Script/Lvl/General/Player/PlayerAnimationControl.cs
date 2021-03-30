using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{
    public Animator animator;
    float idleTimeCounter = 0f;
    bool idleCounterStart = false;
    public bool isFlag = false;
    bool flagAudioPlayed = false; //FOR FLAG AUDIO CHECK (TO PLAY IT ONLY ONCE)
    public AudioSource flagAudio;
    void Update()
    {
        if (isFlag == true && flagAudioPlayed == false)
        {
            flagAudio.Play();
            animator.SetBool("IsFlag", true);
            flagAudioPlayed = true;

        }
        if(isFlag == false)
        {
            animator.SetBool("IsFlag", false);
        }

        if (GetComponent<BasicPlayerMovement>().isDead == true)
        {
            animator.SetBool("IsDead", true);
        }
        if (FindObjectOfType<BasicPlayerMovement>().horizontal != 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(FindObjectOfType<BasicPlayerMovement>().movementSpeed));
        }
        else
        {
            animator.SetFloat("Speed", 0.0f);
        }

        if ( FindObjectOfType<BasicPlayerMovement>().horizontal != 0 && FindObjectOfType<BasicPlayerMovement>().rb.velocity.y == 0)
        {
            idleCounterStart = false;
            animator.SetBool("IsIdle", false);

            animator.SetBool("IsRunning", true);
        }
        else
            animator.SetBool("IsRunning", false);

        if (FindObjectOfType<BasicPlayerMovement>().rb.velocity.y > 0)
        {
            idleCounterStart = false;
            animator.SetBool("IsIdle", false);

            animator.SetBool("IsJumping", true);
        }
        else
            animator.SetBool("IsJumping", false);

        if (FindObjectOfType<BasicPlayerMovement>().rb.velocity.y < 0)
        {
            idleCounterStart = false;
            animator.SetBool("IsIdle", false);

            animator.SetBool("IsFalling", true);
        }
        else
            animator.SetBool("IsFalling", false);

        if (FindObjectOfType<CheckGround>().IsGrounded() == true)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsJumping", false);
        }


        if (FindObjectOfType<CheckGround>().IsGrounded() == true && FindObjectOfType<BasicPlayerMovement>().horizontal == 0)
        {
            if (idleCounterStart == false)
            {
                idleTimeCounter = 2.0f;
                idleCounterStart = true;
            }
        }

        if (idleCounterStart == true)
        {
            idleTimeCounter = idleTimeCounter - Time.deltaTime;
        }
        if (idleTimeCounter < 0 && idleCounterStart == true)
        {
            animator.SetBool("IsIdle", true);
        }
    }
}
