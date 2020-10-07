using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boosLevel1 : MonoBehaviour
{
    public Rigidbody2D teleporter;
    public AudioSource tel;
    // Start is called before the first frame update
    void Start()
    {
        teleporter = GetComponent<Rigidbody2D>();
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
            tel.Play();
            other.gameObject.SetActive(false);


            StartCoroutine("nextScene");
        }

    }
    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("boss level1");
        //   Debug.Log(currentHealth);
    }
}
