using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePrefab : MonoBehaviour
{
    public GameObject prefabFor300;
    public GameObject prefabFor200;
    GameObject pre200;
    GameObject pre300;
    private void Update()
    {
        if (pre200 != null)
        {
            pre200.transform.position += new Vector3(0, 0.01f, 0);
        }
        if (pre300 != null)
        {
            pre300.transform.position += new Vector3(0, 0.01f, 0);
        }
    }

    public void for200()
    {
        pre200= Instantiate(prefabFor200);
        pre200.transform.position = GameObject.Find("player").transform.position + new Vector3(0, 1.5f, 0);
    }

    public void for300()
    {
        pre300= Instantiate(prefabFor300);
        pre300.transform.position = GameObject.Find("player").transform.position + new Vector3(0, 1.5f, 0);
        pre300.transform.position += new Vector3(0, 0.1f, 0);

    }
}
