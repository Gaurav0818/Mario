using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiranhaMovement : MonoBehaviour
{
    public float verticalSpeed;
    public Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    // Update is called once per frame
    void Update()
    {
        rb.transform.position += new Vector3(0, verticalSpeed*Time.deltaTime, 0);
    }
}
