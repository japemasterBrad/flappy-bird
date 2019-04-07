using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Sprite death;
    public Sprite fly2, fly1;
    public GameObject obj;
    public float power;

    bool isEndGame = false;
    int gamePoint = 0;
    public Text txtPoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Time.timeScale = 0;
        obj = gameObject;
        power = 300;
        sprite.sprite = fly1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isEndGame)
        {

            if ((Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) && !isEndGame)
            {
                Time.timeScale = 1;
                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, power));
            }

            if (sprite.sprite == fly1)
            {
                sprite.sprite = fly2;
            }
            else
            {
                sprite.sprite = fly1;
            }
        }
    }

    // Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        EndGame();
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    // Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void EndGame()
    {
        Debug.Log("End");
        Time.timeScale = 0;
        sprite.sprite = death;
        isEndGame = true;        
    }
}
