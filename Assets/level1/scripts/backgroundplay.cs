using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundplay : MonoBehaviour
{
    // Start is called before the first frame update
   // public AudioSource bg;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    
}
