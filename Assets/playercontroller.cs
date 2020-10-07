using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

//using UnityStandardAssets.CrossPlatformInput;

public class playercontroller : MonoBehaviour
{
    public int s = 0,d=0,l=0,r=0;

    public AudioSource knifeWhop, jumpsound;

   public int maxHealth ;
     int currentHealth;
    public HealthBar healthBar;

    private Animator amim;
    //  public Animator rolling;
   // bool isrunning, ifjumpedonce;

    int hey;
   // Vector3 zee;
  //  int i;

    float x1, y1;
    public Rigidbody2D rb,rb1;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public GameObject knife;
    public LayerMask whatIsGround;
    private bool canDoubleJump;
    void Start()
    {
        currentHealth = maxHealth; //currenthealth is going to change as enemy kills
        healthBar.SetMaxHealth(maxHealth);

        rb = GetComponent<Rigidbody2D>();
        rb1 = GetComponent<Rigidbody2D>();
        amim = GetComponent<Animator>();
        //  rolling = GetComponent<Animator>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x1 = rb.transform.position.x;
        y1 = rb.transform.position.y;
      //  z1 = rb.transform.position.z;

       // if (l == 1)
        {
            //moveInput 
           // moveInput = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
           // moveInput = 0;
        }        l = 0;
        //  bool x = Input.GetKeyDown(KeyCode.Space);

        // if (x == true) amim.speed = 0f;
        //  if (moveInput != 0)amim.speed = 1f;
        if (hey== 1)
            {
          //  rb.position = zee;
           // Destroy(rb);
         //   Instantiate(rb1, zee, Quaternion.identity);
                rb1.velocity = new Vector2(1, rb.velocity.y);
            }
        if (d==1)
        {
      Instantiate(knife, new Vector3(x1 + 1.8f, y1, 0f), Quaternion.identity);
            knifeWhop.Play();
            d = 0;
        }
       
      
    }
    void Update()
    {

      
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius,whatIsGround);
        if(isGrounded==true)
        {
            canDoubleJump = true;
            amim.SetBool("isrunning", false);
            amim.SetBool("ifjumpedonce", false);
            amim.speed = 1f;
        }
        if (s==1)
        {
            jumpsound.Play();
            if (isGrounded == true)
            {
                rb.velocity = Vector2.up * jumpForce;
               
            }
            else 
            {
                if (canDoubleJump)
                {
                    amim.speed = 1f;
               
                    //if (Input.GetKeyDown(KeyCode.Space))
                    {
                        rb.velocity = Vector2.up * (jumpForce);
                            amim.SetBool("isrunning", false);
                          amim.SetBool("ifjumpedonce", true);
                    }
                    canDoubleJump = false;

                }
            }
            s = 0;
        }
       
       

    }
    void OnTriggerEnter2D(Collider2D other)
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

            if (currentHealth < 100)
            {
                TakeDamage(-30);
            }

            // other.gameObject.SetActive(false);
            // Instantiate(bomb, new Vector3(7f, 2.6f, 0f), Quaternion.identity);
        }
        if(other.gameObject.CompareTag("batwomen"))
        {
            TakeDamage(10);
        }
        if (other.gameObject.CompareTag("acid"))
        {
            TakeDamage(10);
        }


    }

    //function called in update eg. TakeDamage(20);
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth<=0)
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
    public void space()
    {
        s=1;
    }
    public void mouseClick()
    {
        d=1;;
    }
    public void LeftClick()
    {
        
        moveInput = -1;
    }
    public void NoLeftClick()
    {
        moveInput = 0;
    }
    public void RightClick()
    {
        moveInput = 1;
    }
    public void NoRightClick()
    {
        moveInput = 0;
    }
   

}
