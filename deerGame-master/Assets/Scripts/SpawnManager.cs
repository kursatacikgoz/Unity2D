using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRange = 20;
    private float spawnZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnNewRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnNewRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }


}
