using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuButtonCMD : MonoBehaviour
{
    public void BackButtonPress()
    {
        FindObjectOfType<ifControlPressed>().back = true;
    }
}
