using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LvlUpMenuButtonCMD : MonoBehaviour
{
    public void OnContinueButtonPress()
    {
        EventSystem.current.SetSelectedGameObject(null);
        Debug.Log("Lvl Under Development");
        FindObjectOfType<nextLvlPanal>().showNextLvlPanal();
        

    }
    public void OnMenuButtonPress()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
