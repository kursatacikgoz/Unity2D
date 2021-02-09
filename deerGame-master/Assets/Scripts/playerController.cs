using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 25.0f;
    private float xRange = 20;
    public GameObject[] pizzaPrefabs;


    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("Fire", 0.5f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
            // Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }


    void Fire()
    {
        Instantiate(pizzaPrefabs[0], transform.position, pizzaPrefabs[0].transform.rotation);
    }
}
