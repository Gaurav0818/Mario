using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyWhenJumpOnTop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D ObjectWithTrigger)
    {
        if (ObjectWithTrigger.gameObject.tag == "Enemy" )
        {
            ObjectWithTrigger.gameObject.GetComponent<EnemyMovement>().top = true;
            Destroy(ObjectWithTrigger.gameObject);
        }
    }
}
