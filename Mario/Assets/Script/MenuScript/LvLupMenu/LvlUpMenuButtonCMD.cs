using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlUpMenuButtonCMD : MonoBehaviour
{
    public void OnContinueButtonPress()
    {
        Debug.Log("Lvl Under Development");
    }
    public void OnMenuButtonPress()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
