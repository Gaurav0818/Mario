using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlUpTrigger : MonoBehaviour
{
    public GameObject tip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tip.SetActive(true);
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.S))
        {

            Debug.Log("lvlupcalled");
            FindObjectOfType<LvlOver>().lvlUp();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        tip.SetActive(false);
    }
}
