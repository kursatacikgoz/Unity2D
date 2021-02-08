using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public GameObject hook;
    public GameObject linkPrefab;
    public Weight weight;

    public int links = 7;

    // Start is called before the first frame update
    void Start()
    {
        GenerateRope();
    }

    private void GenerateRope()
    {
        Rigidbody2D previousRB = hook.GetComponent<Rigidbody2D>();
        GameObject link;
        HingeJoint2D joint;
        for (int i = 0; i < links; i++)
        {
            link = Instantiate(linkPrefab, transform);
            joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;
            if (i < links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
            
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
