using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
    public GameObject Sprite;
    public float xMin, xMax, yMin, yMax;
   
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
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Instantiate(Sprite, new Vector2(randomX, randomY), Quaternion.identity);
        }

    }
}
