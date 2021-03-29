using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifControlPressed : MonoBehaviour
{
    public bool option = false;
    public GameObject optionMenu;
    public GameObject escapeMenu;

    private void Update()
    {
        if (option == true)
        {
            escapeMenu.SetActive(false);
            optionMenu.SetActive(true);
        }
    }
    public void backPressed()
    {
        optionMenu.SetActive(false);
        escapeMenu.SetActive(true);
    }
}
