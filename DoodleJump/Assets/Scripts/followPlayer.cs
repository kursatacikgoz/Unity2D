using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    public float smoothSpeed = .4f;
    private Vector3 curVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if(player.transform.position.y>transform.position.y)
        {
            Vector3 temp = transform.position;
            temp.y = player.transform.position.y;
            transform.position = temp;
            // transform.position = Vector3.SmoothDamp(transform.position, temp, ref curVelocity, smoothSpeed * Time.deltaTime);
        }
    }
}
