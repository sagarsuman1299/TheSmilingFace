using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class police : MonoBehaviour
{
    public Rigidbody2D pol;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        pol = GetComponent<Rigidbody2D>();
     //  ami = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
