using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePrefab : MonoBehaviour
{
    public GameObject prefabFor300;
    public GameObject prefabFor200;

    public void for200()
    {
        GameObject pre200= Instantiate(prefabFor200);
        pre200.transform.position = GameObject.Find("player").transform.position + new Vector3(0, 1.5f, 0);

    }

    public void for300()
    {
        GameObject pre300= Instantiate(prefabFor300);
        pre300.transform.position = GameObject.Find("player").transform.position + new Vector3(0, 1.5f, 0);

    }
}
