using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run2 : MonoBehaviour
{
    public Rigidbody2D particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("joker"))
        {
          //  other.gameObject.velocity = new Vector2(20, 0);
            //  rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        }

    }
   
}
