using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject ddol;
    private void Start()
    {
        var ddol0 = GameObject.Find("DontDestroyOnLoad");
        if (ddol0 == null)
        {
            ddol0 = Instantiate(ddol);
            ddol0.name = "DontDestroyOnLoad";
        }
    }
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
