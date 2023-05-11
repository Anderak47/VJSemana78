using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneradorZombieController : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float velocity = 0.9f;
    private Rigidbody2D rb;
    //agregar esto para un prefab
    public GameManager gameManager;
    public int balasRecibidas = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        //agregar esto para un prefab
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        rb.velocity = new Vector2(-velocity, 0);
        sr.flipX = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "balaDead")
        {
            //para que lo mate de 2 balas
            balasRecibidas++;
            if (balasRecibidas == 2)
            {
                NumeroMuerte();
                Destroy(this.gameObject);
            }
        }  
    }
    private void NumeroMuerte()
    {
        gameManager.MuerteZombie();
    }
}
