using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckifPause : MonoBehaviour
{
    public bool gamepause = false;
    public float timer;
    private void Update()
    {
        if (gamepause == false)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Debug.Log("Escape pressed (toEnter)");
                gamepause = true;
                
            }
        }

        if (gamepause == true)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Debug.Log("Escape pressed (toClose)");
                gamepause = false;
            }
        }
    }
}
