using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public float time;

    private void Start()
    {
        time = 0;
    }
    private void Update()
    {
        time += Time.deltaTime;   
    }
}
