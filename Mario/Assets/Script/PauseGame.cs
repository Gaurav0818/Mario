using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public bool pauseGame = false;
    public GameObject pauseOption;
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape) && pauseGame == false)
        {
            pauseGame = true;
        }
        if (pauseGame == true)
        {
            Time.timeScale = 0;
            pauseOption.SetActive(true);
            
        }
        if (Input.GetKey(KeyCode.Escape) && pauseGame == true)
        {
            pauseGame = false;
            Time.timeScale = 1;
        }

    }
}
