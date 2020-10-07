using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmovement : MonoBehaviour
{
    public Rigidbody2D ground;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ground.velocity = (new Vector2(speed,0f));
    }
}
