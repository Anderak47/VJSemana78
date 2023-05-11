using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeHombreController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocityY = rb.velocity.y;
        rb.velocity = new Vector2(0, velocityY);
        //derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(13, velocityY);
            sr.flipX = false;
        }
        //izquierda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-13, velocityY);
            sr.flipX = true;

        }
    }
}
