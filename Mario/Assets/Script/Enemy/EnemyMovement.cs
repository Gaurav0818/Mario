using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float enemySpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.transform.position= rb.transform.position += new Vector3( enemySpeed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = rb.transform.position += new Vector3(enemySpeed * Time.deltaTime, 0, 0);
    }
}
