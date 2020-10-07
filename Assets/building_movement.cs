using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building_movement : MonoBehaviour
{
    public float pace,velocity;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-Time.deltaTime * pace, rb.velocity.y);
        float a = rb.transform.position.x;
        if (a == 0) { Instantiate(rb,new Vector3(6.4f,-0.84f,0),Quaternion.identity); }
    }
}
