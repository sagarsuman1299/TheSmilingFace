using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class robinscript : MonoBehaviour
{
    public Rigidbody2D batwomencartoon;
    int maxHealth = 140;
    int currentHealth;
   // public int sagar;
    public HealthBar healthBarBatwomen;

    float x1, y1;
    public GameObject robinrank;
    public float startTimeBtwShots;
    private float timeBtwShots;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //currenthealth is going to change as enemy kills
        healthBarBatwomen.SetMaxHealth(maxHealth);

        batwomencartoon = GetComponent<Rigidbody2D>();

        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        x1 = batwomencartoon.transform.position.x;
        y1 = batwomencartoon.transform.position.y;
        if (timeBtwShots<=0)
        {
          //  Debug.Log("kaise ho");
            Instantiate(robinrank, new Vector3((x1 - 1.8f), (y1 - 1f), 0f), Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else { timeBtwShots -= Time.deltaTime; }
    }
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("knife"))
        {

            //  Debug.Log("h");
            TakeDamage(1);
          
        }
        if(other.gameObject.CompareTag("hammer"))
        {
            TakeDamage(1);
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
           // sagar = 22;
            // Debug.Log(currentHealth);
            StartCoroutine("nextScene");
        }

    }
    IEnumerator nextScene()
    {
        transform.position = new Vector3(100, 100, 100);
        //  Debug.Log("level2");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Story OverView");
        //   Debug.Log(currentHealth);
    }

}
