using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    public SpriteRenderer sr;

    public Color colorYellow;
    public Color colorGreen;
    public Color colorBlue;
    public Color colorRed;

    // Start is called before the first frame update
    void Start()
    {
        SetRandomCalor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomCalor()
    {
        int num = Random.Range(0, 4);

        switch (num)
        {
            case 0:
                sr.color = colorRed;
                break;
            case 1:
                sr.color = colorBlue;
                break;
            case 2:
                sr.color = colorYellow;
                break;
            case 3:
                sr.color = colorGreen;
                break;
        }

    }
}
