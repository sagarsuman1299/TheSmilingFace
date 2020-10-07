using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eat2 : MonoBehaviour
{
    public Rigidbody2D blackhole;
    // Start is called before the first frame update
    void Start()
    {
        blackhole = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("hquin"))
        {
            other.gameObject.SetActive(false);
        }
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("joker"))
        {
            other.gameObject.SetActive(false);

            StartCoroutine("nextScene");
        }

    }
    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("gameover2");
        //   Debug.Log(currentHealth);
    }
}
