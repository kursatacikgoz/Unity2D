using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text text;


    public void increaseScore()
    {
        this.score++;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
}
