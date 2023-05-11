using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoventHombre : MonoBehaviour
{
    // Start is called before the first frame update
    public SaltarController saltar;
    public float jumpForce1 = 1020f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("valor es " + saltar.canJump1);
            if (saltar.canJump1)
            {
                Debug.Log("puede saltar");
                rb.AddForce(new Vector2(0, jumpForce1));
                saltar.canJump1 = false;
                Debug.Log("valor es " + saltar.canJump1);
            }
        }
    }
}
