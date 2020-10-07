using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
    public float cameradistance = 30f;
    private void Awake()
    {
      //  GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameradistance);
    }
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }
}
