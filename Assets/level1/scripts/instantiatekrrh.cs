using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiatekrrh : MonoBehaviour
{
    public GameObject policwa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(policwa,new Vector3(11.83f -4.01f,-0.086f),Quaternion.identity);
    }
}
