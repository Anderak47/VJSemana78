using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CasaEscena : MonoBehaviour
{
    public GameObject gameManager;
    bool readerCollision = false;
    public float distanceLimit = 4f; // distancia l�mite para cambiar de escena
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChocoCasaEscena() {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        var gm = gameManager.GetComponent<GameManager>();
        var uim = gameManager.GetComponent<UIManager>();
        // si choca y aplasta el botton se cambia de escena
        if (readerCollision && distance <= distanceLimit /*&& gm.GetMuerte()==3 && gm.GetMonedas() ==1*/)
        {
            SceneManager.LoadScene("Escena2");
        }
        // si el jugador est� fuera de la distancia l�mite y choca y aplasta el bot�n, se muestra un mensaje en la consola
        if (readerCollision && distance > distanceLimit)
        {
            Debug.Log("El jugador est� fuera de la distancia l�mite.");
        }
        if (!readerCollision)
        {
            Debug.Log("El jugador se alej� de la casa.");
            readerCollision = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            readerCollision = true;
            Debug.Log("Choco casa escena");
       
        }
    }
}
