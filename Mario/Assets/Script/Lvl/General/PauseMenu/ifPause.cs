using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ifPause : MonoBehaviour
{
    public GameObject canvas;
    public GameObject escapeMenu;
    public GameObject _escapeMenu;
    private void Update()
    {
       

        if (FindObjectOfType<CheckifPause>().gamepause == true)
        {
            Time.timeScale = 0;
            _escapeMenu = GameObject.Find("Escape");
            if (_escapeMenu == null)
            {
                _escapeMenu = GameObject.Instantiate(escapeMenu, canvas.transform);
                _escapeMenu.name = "Escape";
            }
        }

        if(FindObjectOfType<CheckifPause>().gamepause == false)
        {
            Time.timeScale = 1;
            Destroy(GameObject.Find("Escape"));
        }
    }
}
