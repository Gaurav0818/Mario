using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideWithMystryTiles : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Score>().score += 200;
            FindObjectOfType<ScorePrefab>().for200();
            FindObjectOfType<DestroyMystryTiles>().ReplaceMystryTiles(this.gameObject);
        }
    }
}
