using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject player;
    public int numOfPlatform = 100;
    public float levelWidth = 3f;
    private float minY = .8f;
    private float maxY = 2f;
    private float minX = -2f;
    private float maxX = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("dsasdfdfgdfgf");
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < numOfPlatform; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(minX, maxX);
            platformPrefab.GetComponent<Platform>().player = player;
            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
 