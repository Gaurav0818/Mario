using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool isGrounded= false;
    string colName;
    void Start()
    {
        //isGrounded = false; 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "MystryTiles" || collision.collider.tag == "AirTiles" || collision.collider.tag =="WoodenTiles" || collision.collider.tag == "Pipe" || collision.collider.tag == "HiddenScoreTiles" || collision.collider.tag == "HardTiles")
        {
            isGrounded = true;
            colName = collision.collider.name;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "MystryTiles" || collision.collider.tag == "AirTiles" || collision.collider.tag == "WoodenTiles" || collision.collider.tag == "Pipe" || collision.collider.tag == "HiddenScoreTiles" || collision.collider.tag == "HardTiles" && collision.collider.name==colName)
        {
            isGrounded = false;
        }
    }

}
