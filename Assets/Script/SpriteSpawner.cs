using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
    public GameObject kotak;
   
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        int numberToSpawn = Random.Range(5, 10);
        for (int i = 0; i < numberToSpawn; i++)
        {
            float randomX = Random.Range(-7, 7);
            float randomY = Random.Range(-3, 3);
            Instantiate(kotak, new Vector2(randomX, randomY), Quaternion.identity);
        }

    }
}
