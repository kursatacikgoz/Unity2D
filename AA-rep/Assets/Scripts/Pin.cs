using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned=false;

    private float speed = 30f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            // collision.GetComponent<Rotater>().speed *= -1f; // to change direction of rotators rotation
            isPinned = true;
            FindObjectOfType<Score>().increaseScore();
        }else if (collision.tag == "Pin")
        {
            FindObjectOfType<gameController>().EndGame();
        }
    }
}
