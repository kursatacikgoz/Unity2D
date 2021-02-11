using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public Rigidbody2D Anker;
    public GameObject nextPlayer;
    private bool isPressed = false;
    public float releasetime = .15f;
    private float maxDraggableDist = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Debug.Log(mousePosition + "         " + Anker.position + "              " + Vector3.Distance(mousePosition, Anker.position));
            if (Vector3.Distance(mousePosition, Anker.position) <= maxDraggableDist)
            {
                rb.position = mousePosition;
            }
            else
            {
                rb.position = Anker.position + (mousePosition - Anker.position).normalized * maxDraggableDist;
            }
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releasetime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
        yield return new WaitForSeconds(2f);
        // Debug.Log(nextPlayer);
        if (transform.parent.GetComponent<GameControl>().getAliveEnemies() > 0 && nextPlayer != null)
        {
            nextPlayer.SetActive(true);
        }else if(transform.parent.GetComponent<GameControl>().getAliveEnemies() > 0 && nextPlayer == null)
        {
            Debug.Log("Game Over");
            transform.parent.GetComponent<GameControl>().EndGame();
        }

    }

}
