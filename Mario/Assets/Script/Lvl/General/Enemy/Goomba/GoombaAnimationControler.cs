using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaAnimationControler : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (gameObject.GetComponent<EnemyMovement>().isDead == true)
        {
            animator.SetBool("EnemyDead", true);
        }
    }
}
