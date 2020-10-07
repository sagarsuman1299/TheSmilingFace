using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobinSymbolRotar : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D sign;
    void Start()
    {
        sign = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 15));
        sign.velocity = (new Vector2(-8, 0));
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("joker"))
        {
            Destroy(gameObject);
        }
    }
}