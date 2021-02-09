using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private float speed = 35.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput = 1;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(horizontalInput < 0.25)
        {
            horizontalInput = 0.25f;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        transform.Rotate(Vector3.left, Time.deltaTime * turnSpeed * verticalInput);

        
    }
}
