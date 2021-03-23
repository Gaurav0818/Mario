using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<BasicPlayerMovement>())
        {
            transform.position = new Vector3(FindObjectOfType<BasicPlayerMovement>().rb.transform.position.x, 0, -10);
        }
        else
        {
            transform.position = transform.position;
        }
    }
}
