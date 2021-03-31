using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreByHiddenTiles : MonoBehaviour
{
    int count = 0;
    int maxcount = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (count <  maxcount)
            {
                count++;
                FindObjectOfType<Score>().score += 200;
                FindObjectOfType<ScorePrefab>().for200();
            }else if(count== maxcount || count > maxcount)
            {
                FindObjectOfType<DestroyHiddenTiles>().ReplaceHiddenTiles(this.gameObject);
            }
        }
    }

}
