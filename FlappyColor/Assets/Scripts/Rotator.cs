using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;
    public Player player;
    private bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f, speed * Time.deltaTime);
        if (player.transform.position.y > transform.position.y + 2 && isActive)
        {
            isActive = false;
            FindObjectOfType<GameManager>().setScore(FindObjectOfType<GameManager>().getScore() + 1);
            FindObjectOfType<GameManager>().spawnObject(player.transform.position.y +7 );
        }else if (player.transform.position.y > transform.position.y + 10)
        {
            Destroy(transform.gameObject);
        }
    }
}
