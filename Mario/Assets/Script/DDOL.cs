using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    public float scoreDDOL;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if(FindObjectOfType<Score>() !=null)
            scoreDDOL = FindObjectOfType<Score>().score;
    }
}
