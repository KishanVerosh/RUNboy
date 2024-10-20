using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    Rigidbody2D rigidbody2;
    void Start()
    {
        rigidbody2=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        go();
    }
    void go()
    {
        rigidbody2.velocity = new Vector2(-3f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collector"))
        {
            Destroy(gameObject);
        }
    }
}
