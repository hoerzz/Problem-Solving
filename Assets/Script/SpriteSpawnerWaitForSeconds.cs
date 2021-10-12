using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawnerWaitForSeconds : SpriteSpawner
{
    public IEnumerator SpawnSprite()
    {
        if (transform.childCount < 10)
        {
            float randomX = Random.Range(-6, 6);
            float randomY = Random.Range(-4, 4);

            Instantiate(kotak, new Vector2(randomX, randomY), Quaternion.identity); 
            
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnSprite()); 
    }
}
