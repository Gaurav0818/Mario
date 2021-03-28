using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlOver : MonoBehaviour
{
    public void lvlUp()
    {
        SceneManager.LoadScene("LvlupMenu");
    }
}
