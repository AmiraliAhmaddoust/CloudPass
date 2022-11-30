using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bird : MonoBehaviour
{
    private Rigidbody2D body;
    public int Score = 0;
    public float UpSpeed;
    public TextMeshProUGUI ScoreText;
    public GameOver GameOver;
   
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        UpSpeed = 1f;
    }

   
    void Update()
    {
        ScoreText.text = "Score :" + Score;
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
        //    this.gameObject.transform.Translate(0f, UpSpeed, 0f);
           body.velocity = new Vector2(body.velocity.x, UpSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Score++;
            //   Debug.Log(Score);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ground")
        {

            GameOver.SetUp(Score);
            Debug.Log("in ground");
            
        }
    }

}
