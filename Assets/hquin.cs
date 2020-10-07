using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hquin : MonoBehaviour
{
    public AudioSource knifeWhop, jumpsound;

    int s;

    int maxHealth = 50;
    int currentHealth;
    public HealthBar healthBar;

    private Animator amim;
    //  public Animator rolling;
    bool isrunning, ifjumpedonce;

  //  int hey;
   
    float x1, y1;
    public Rigidbody2D rbh;
    public float speed;
    public float jumpForce;
   //private float moveInput;
    //private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public GameObject knife;
    public LayerMask whatIsGround;
    //private bool canDoubleJump;
    void Start()
    {
        currentHealth = maxHealth; //currenthealth is going to change as enemy kills
        healthBar.SetMaxHealth(maxHealth);

        rbh = GetComponent<Rigidbody2D>();
      //  rb1 = GetComponent<Rigidbody2D>();
        amim = GetComponent<Animator>();
        //  rolling = GetComponent<Animator>();

        int sagar = gameObject.GetComponent<batwomen>().sagar;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x1 = rbh.transform.position.x;
        y1 = rbh.transform.position.y;
       // z1 = rbh.transform.position.z;


       // moveInput = Input.GetAxisRaw("Horizontal");
      //  rbh.velocity = new Vector2(moveInput * speed, rbh.velocity.y);
        //  bool x = Input.GetKeyDown(KeyCode.Space);

        // if (x == true) amim.speed = 0f;
        //  if (moveInput != 0)amim.speed = 1f;
    /*    if (hey == 1)
        {
            rbh.position = zee;
            // Destroy(rb);
            Instantiate(rb1, zee, Quaternion.identity);
            rb1.velocity = new Vector2(1, rbh.velocity.y);
        } */
        if (s==1)
        {
            Debug.Log("kemcho");
            Instantiate(knife, new Vector3(x1-1 ,y1, 0f), Quaternion.identity);
            knifeWhop.Play();
            s = 0;
        }


    }
    void Update()
    {

        /*  isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
          if (isGrounded == true)
          {
              canDoubleJump = true;
              amim.SetBool("isrunning", false);
              amim.SetBool("ifjumpedonce", false);
              amim.speed = 1f;
          }
          if (Input.GetKeyDown(KeyCode.Space))
          {
              jumpsound.Play();
              if (isGrounded == true)
              {
                  rbh.velocity = Vector2.up * jumpForce;

              }
              else
              {
                  if (canDoubleJump)
                  {
                      amim.speed = 1f;

                      //if (Input.GetKeyDown(KeyCode.Space))
                      {
                          rbh.velocity = Vector2.up * (jumpForce);
                          amim.SetBool("isrunning", false);
                          amim.SetBool("ifjumpedonce", true);
                      }
                      canDoubleJump = false;

                  }
              }
          }  */



    }
    /*   void OnTriggerEnter2D(Collider2D other)
       {
           if (other.CompareTag("jokerRunner"))
           {
               hey = 1;
           }
           //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
           if (other.gameObject.CompareTag("enemy"))
           {


               TakeDamage(10);


               // other.gameObject.SetActive(false);
               // Instantiate(bomb, new Vector3(7f, 2.6f, 0f), Quaternion.identity);
           }
           if (other.gameObject.CompareTag("energyCan"))
           {

               if (currentHealth < 40)
               {
                 //  TakeDamage(-30);
               }
               else { TakeDamage(0); }
               // other.gameObject.SetActive(false);
               // Instantiate(bomb, new Vector3(7f, 2.6f, 0f), Quaternion.identity);
           }



       } */

    //function called in update eg. TakeDamage(20);
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {

            StartCoroutine("nextScene");


        }

    }
    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(0f);

        batwomen SAGAR = gameObject.GetComponent<batwomen>();

        // if (SAGAR.sagar == 22)
        {
            //   SceneManager.LoadScene("gameover2");
        }
        // else 
        {
            SceneManager.LoadScene("gameover2");
            //   Debug.Log("hoo");
        }
        //   Debug.Log(currentHealth);
    }
    public void RightClick()
    {
        s = 1;
    }
    public void NoRightClick()
    {
        s = 0;
    }



}
