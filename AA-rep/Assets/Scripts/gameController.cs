using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public bool isContinue = true;
    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;


    public void EndGame()
    {
        if (isContinue == false)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("endGame");

        isContinue = false;
        
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
