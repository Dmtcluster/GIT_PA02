using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float Positionx;
    int RandomInt;
    public GameObject[] Spawnobject;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnObjects()
    {
        RandomInt = Random.Range(0, Spawnobject.Length);
        Positionx = Random.Range(-1.5f,1.5f);
        this.transform.position = new Vector3(Positionx, 0.5f, transform.position.z);
        // Instantiate(SpawnObject, transform.position, transform.rotation);
        Instantiate(Spawnobject[RandomInt], transform.position, transform.rotation);

    }

    
}
