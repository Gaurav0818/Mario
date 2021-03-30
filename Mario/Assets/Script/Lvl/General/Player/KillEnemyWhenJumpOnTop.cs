using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemyWhenJumpOnTop : MonoBehaviour
{
    public string Ename="null";
    
    
    void OnTriggerEnter2D(Collider2D ObjectWithTrigger)
    {
        if (ObjectWithTrigger.gameObject.CompareTag("Enemy") && Ename!=ObjectWithTrigger.gameObject.name )
        {
            ObjectWithTrigger.gameObject.GetComponent<EnemyMovement>().isDead=true;
            Ename = ObjectWithTrigger.name;
            Destroy(ObjectWithTrigger.gameObject,2f);
            FindObjectOfType<Score>().score += 200;
        }
    }
}
