using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifPause : MonoBehaviour
{
    public GameObject pauseMenu;
    private void Update()
    {
        if (FindObjectOfType<CheckifPause>().gamepause == true)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }

        if(FindObjectOfType<CheckifPause>().gamepause == false)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }
}
