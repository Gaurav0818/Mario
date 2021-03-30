using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifControlPressed : MonoBehaviour
{
    public GameObject canvas;
    public bool option = false;
    public bool back = false;
    public GameObject optionMenu;
    public GameObject _optionMenu;

    private void Update()
    {
        if (option == true)
        {
            GameObject.Find("Escape").SetActive(false);
            _optionMenu = GameObject.Find("ControlPanal");
            if (_optionMenu == null)
            {
                _optionMenu = GameObject.Instantiate(optionMenu, canvas.transform);
                _optionMenu.name = "ControlPanal";
            }
        }
        if (back == true)
        {
            backPressed();
        }
    }
    public void backPressed()
    {
        back = false;
        option = false;
        Destroy(GameObject.Find("ControlPanal"));
        if(GameObject.Find("Escape")!=null)
            GameObject.Find("Escape").SetActive(true);
    }
}
