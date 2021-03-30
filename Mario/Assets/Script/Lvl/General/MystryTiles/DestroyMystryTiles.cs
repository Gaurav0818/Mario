using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMystryTiles : MonoBehaviour
{
    public GameObject destroyedMystryTiles;
    public void ReplaceMystryTiles(GameObject mystrytile)
    {
        Vector3 pos = mystrytile.transform.position;
        Destroy(mystrytile);
        GameObject newTile = Instantiate(destroyedMystryTiles);
        newTile.transform.position = pos;
    }
}
