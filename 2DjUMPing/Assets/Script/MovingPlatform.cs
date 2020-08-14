using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    bool ismoving;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "MovingPlatform")
        {
            GetComponent<Rigidbody2D>().isKinematic = true;
            transform.parent = collision.transform;
            
        }
        
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            transform.parent = null;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            transform.parent = null;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            transform.parent = null;
        }
       
    }
}
