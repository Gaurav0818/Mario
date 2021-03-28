using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickSmash : MonoBehaviour
{
    public AudioSource bricksmsh;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WoodenTiles"))
        {
            Destroy(collision.gameObject);
            bricksmsh.Play();
        }
    }
}
