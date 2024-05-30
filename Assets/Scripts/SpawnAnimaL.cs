using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimaL : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animals;
    public Transform[] spawns;
    private int index, indexSpawn;
    void Start()
    {
        InvokeRepeating("Spawn", 5, 3);
    }

    void Spawn()
    {
        index = Random.Range(0, animals.Length);
        indexSpawn = Random.Range(0, spawns.Length);
        Instantiate(animals[index], spawns[indexSpawn].position, spawns[indexSpawn].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
