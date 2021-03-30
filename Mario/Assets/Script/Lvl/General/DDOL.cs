using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    public float scoreDDOL;
    public float timeDDOL;
    public float maxTime;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (FindObjectOfType<GameTime>() != null)
            timeDDOL = FindObjectOfType<GameTime>().time;
        if (FindObjectOfType<MaxTime>() != null)
            maxTime = FindObjectOfType<MaxTime>().maxTime;
        if(FindObjectOfType<Score>() !=null)
            scoreDDOL = FindObjectOfType<Score>().score;
    }
}
