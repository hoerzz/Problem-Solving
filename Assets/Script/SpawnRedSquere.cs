using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRedSquere : MonoBehaviour
{
    public GameObject kotakMerah;

    private void Start() {
        RedSquereSpawner();
    }
    
    public void RedSquereSpawner()
    {
        bool RedSquereSpawned = false;
        while (!RedSquereSpawned)
        {
            Vector3 RedSquerePosition = new Vector3(Random.Range(-7f,7f), Random.Range(-4f,4f), 0f);
            if((RedSquerePosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                RedSquereSpawned = true;
                StartCoroutine(DelaySpawn());
            }
        }
    }
    IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(2);
        Vector3 RedSquerePosition = new Vector3(Random.Range(-5f,5f), Random.Range(-3f,3f), 0f);
        Instantiate(kotakMerah, RedSquerePosition, Quaternion.identity);
    }
}
