using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class batwomen : MonoBehaviour
{
    public Rigidbody2D batwomencartoon;
    int maxHealth = 100;
    int currentHealth;
    public int sagar;
    public HealthBar healthBarBatwomen;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //currenthealth is going to change as enemy kills
        healthBarBatwomen.SetMaxHealth(maxHealth);

        batwomencartoon = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
      
        if (other.gameObject.CompareTag("knife" ))
        {

          //  Debug.Log("h");
            TakeDamage(1);
            if(currentHealth<=0)
            { // Destroy(gameObject);
               // StartCoroutine("nextScene");
            }

            // other.gameObject.SetActive(false);
            // Instantiate(bomb, new Vector3(7f, 2.6f, 0f), Quaternion.identity);
        }
          }

    //function called in update eg. TakeDamage(20);
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBarBatwomen.SetHealth(currentHealth);
      //  Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            sagar = 22;
           // Debug.Log(currentHealth);
            StartCoroutine("nextScene");
        }

    }
    IEnumerator nextScene()
    {
      //  Debug.Log("level2");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("harl");
        //   Debug.Log(currentHealth);
    }

}
