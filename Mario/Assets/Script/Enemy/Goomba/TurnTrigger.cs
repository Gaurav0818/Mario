using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.transform.eulerAngles += new Vector3(0, 180, 0);
            collision.GetComponent<EnemyMovement>().enemySpeed *= -1;
        }
        
    }

}
