using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float jumpForce = 6f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string curColor;
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
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "ColorChanger")
        {
            SpriteRenderer sprite;
            sprite = collision.GetComponent<SpriteRenderer>();
            sr.color= sprite.color;
            FindObjectOfType<GameManager>().spawnObject(transform.position.y + 7);
            Destroy(collision.gameObject);
        }else if (collision.tag != curColor)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SetRandomCalor()
    {
        int num=Random.Range(0,4);

        switch (num)
        {
            case 0:
                this.curColor = "Red";
                sr.color = colorRed;
                break;
            case 1:
                this.curColor = "Blue";
                sr.color = colorBlue;
                break;
            case 2:
                this.curColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 3:
                this.curColor = "Green";
                sr.color = colorGreen;
                break;
            default:
                this.curColor = "Red";
                sr.color = colorRed;
                break;
        }

    }
}
