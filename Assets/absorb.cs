using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class absorb : MonoBehaviour
{
    public Rigidbody2D groundCollider;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("joker"))
        {
          //  Debug.Log("reav");
            other.gameObject.SetActive(false);
            StartCoroutine("nextScene");
        }
        if(other.gameObject.CompareTag("sword"))
        {
            
            other.gameObject.SetActive(false);
        }
    }
    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("gameover");
        //   Debug.Log(currentHealth);
    }
}
