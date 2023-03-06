using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float firstspawnRangeX = -10;
    private float secondspawnRangeX = -17;
    private float spawnRangeZ = 20;
    public float startDelay = 1.2f;
    public float spawnInterval = 1.7f;


    // Start is called before the first frame update
    void Start()
    {
        // creates the animals.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnRandomAnimal()
    {
        // finds the animal prefabs so that the invoke method can pull them randomly and have them spawn with the right transform.
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float spawnX = Random.Range(firstspawnRangeX, secondspawnRangeX);
        float spawnZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

}