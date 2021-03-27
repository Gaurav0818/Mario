using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float enemySpeed;
   // public bool top=false;
    public bool isDead ; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.transform.position= rb.transform.position += new Vector3( enemySpeed * Time.deltaTime, 0, 0);
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = rb.transform.position += new Vector3(enemySpeed * Time.deltaTime, 0, 0);
        if (isDead == true)
        {
            enemySpeed = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" )
        {
            transform.eulerAngles += new Vector3(0, 180, 0);
            enemySpeed *= -1;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        transform.eulerAngles += new Vector3(0, 180, 0);
        enemySpeed *= -1;
        

    }
}
