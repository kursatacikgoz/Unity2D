using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private int aliveEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        // aliveEnemies = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void checkFinished()
    {
        //Debug.Log("ife girmeden " + aliveEnemies);
        if (aliveEnemies <= 0)
        {
            Debug.Log("End");
            //Debug.Log(aliveEnemies);
            EndGame();

        }
    }

    public void increaseAliveEnemy()
    {
        //Debug.Log("inc");
        aliveEnemies++;
        //Debug.Log(aliveEnemies);
    }

    public void decreaseAliveEnemy()
    {
        //Debug.Log("dec");
        aliveEnemies--;
        //Debug.Log(aliveEnemies);
    }

    public int getAliveEnemies()
    {
        return aliveEnemies;
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
