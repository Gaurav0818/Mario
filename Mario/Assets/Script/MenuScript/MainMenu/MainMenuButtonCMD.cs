using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonCMD : MonoBehaviour
{
    public void OnPlayButtonPress()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitButtonPress()
    {
        Application.Quit();
    }
}
