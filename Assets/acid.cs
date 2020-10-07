using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acid : MonoBehaviour
{
    int i ;
    public GameObject boond;
    // Start is called before the first frame update
    void Start()
    {
     // boond = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
       // Debug.Log(i);
        if (i % 100 == 0)
        {
            Debug.Log(i);
            Instantiate(boond ,new Vector3(-225f,115f, 0), Quaternion.identity);
            boond.transform.position = new Vector2(0, -30 * Time.deltaTime);
        }
    }
}
