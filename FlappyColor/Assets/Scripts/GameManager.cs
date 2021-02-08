using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text text;
    public GameObject[] circlePrefabs;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameObject circle = circlePrefabs[0];
        circle.GetComponent<Rotator>().player = player;
        Instantiate(circle, new Vector3(0, 3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + score;
    }

    public int getScore()
    {
        return score;
    }

    public void setScore(int s)
    {
        score = s;
    }

    public void spawnObject(float y)
    {
        int randomNum; 

        if (score < 3 )
        {
            randomNum = Random.Range(0, 1);
        }
        else if (score < 7)
        {
            randomNum = Random.Range(0, 2);
        }
        else if (score < 12)
        {
            randomNum = Random.Range(0, 3);
        }else 
        {
            randomNum = Random.Range(0, 4);
        }

        GameObject circle = circlePrefabs[randomNum];
        Debug.Log(randomNum);
        if(randomNum!=1)
            circle.GetComponent<Rotator>().player = player;
        else
        {
            circle.GetComponent<colorChanger>().sr = circle.GetComponent<SpriteRenderer>();
        }
        Instantiate(circle, new Vector3(0f, y, 0f), Quaternion.identity);

    }
}
