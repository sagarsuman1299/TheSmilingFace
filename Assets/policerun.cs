﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policerun : MonoBehaviour
{
    Animator amim;
    public Rigidbody2D rb;
    public float pace;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        amim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(-Time.deltaTime * pace, rb.velocity.y);
        amim.speed = 1f;
        float a = Random.Range(1, 1000);
        if (a == 1) Instantiate(rb, new Vector3(12.18f, -2.2f, 0f), Quaternion.identity);
        //     if (rb.position.y < -5) Destroy(rb);

    }
 /* void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("knife"))
        {
            other.gameObject.SetActive(false);
        }
    }  */
}