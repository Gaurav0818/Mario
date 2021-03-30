using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonCMD : MonoBehaviour
{
    public void OnResumeButtonPress()
    {
        FindObjectOfType<CheckifPause>().gamepause = false;
    }
    
    public void OnRestartButtonPress()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void OnOptionButtonPress()
    {
        
        FindObjectOfType<ifControlPressed>().option = true;
    }
    public void OnMenuButtonPress()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
