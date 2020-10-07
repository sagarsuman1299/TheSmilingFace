using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunes : MonoBehaviour
{
    public AudioSource knifeWhop, jumpsound;
    private void Start()
    {
        
    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
          //  knifeWhop.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // jumpsound.Play();
        }
    }
 
}
