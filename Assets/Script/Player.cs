using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Rigidbody2D RB;
    private bool isGD;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        jump();
    }

    void jump() {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && isGD == true) {
            RB.AddForce(new Vector2(0f,10f),ForceMode2D.Impulse);
            isGD =false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGD = true;
        }

        if (collision.gameObject.CompareTag("Girl"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("main");
        }
    }
}
