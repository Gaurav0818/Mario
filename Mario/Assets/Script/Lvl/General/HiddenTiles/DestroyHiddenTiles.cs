using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHiddenTiles : MonoBehaviour
{
    public GameObject destroyedHiddenTiles;
    public void ReplaceHiddenTiles(GameObject hiddentile)
    {
        Vector3 pos = hiddentile.transform.position;
        Destroy(hiddentile);
        GameObject newTile = Instantiate(destroyedHiddenTiles);
        newTile.transform.position = pos;
    }
}
