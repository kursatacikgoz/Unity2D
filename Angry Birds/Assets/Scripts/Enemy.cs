using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject dieEffect;
    public float health = 4f;

    // Start is called before the first frame update
    void Start()
    {
        transform.parent.GetComponent<GameControl>().increaseAliveEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health -= collision.relativeVelocity.magnitude;
        //Debug.Log(health);
    }

    private void Die()
    {
        Instantiate(dieEffect, transform.position, Quaternion.identity);
        transform.parent.GetComponent<GameControl>().decreaseAliveEnemy();
        transform.parent.GetComponent<GameControl>().checkFinished();
        Destroy(gameObject);
        
    }

    
}
