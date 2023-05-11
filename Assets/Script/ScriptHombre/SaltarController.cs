using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltarController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canJump1 = false;
    private int numContacts = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (numContacts > 0)
        {
            canJump1 = true;
        }
        else
        {
            canJump1 = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        numContacts++;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        numContacts--;
    }
}
