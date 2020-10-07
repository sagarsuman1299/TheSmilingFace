using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D pt;
    // Start is called before the first frame update
    void Start()
    {
        pt = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pt.velocity = new Vector2(speed,0f);
    }
}
