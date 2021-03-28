using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuButtonCMD : MonoBehaviour
{
    public void OnRestartButtonPress()
    {
        SceneManager.LoadScene(1);
    }
    public void OnMenuButtonPress()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
