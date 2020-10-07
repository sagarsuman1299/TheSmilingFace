using UnityEngine;

public class knifeanim : MonoBehaviour
{
   public Rigidbody2D kn;
    public GameObject bloodSplash;
  //  int i = 0;
  //  public AudioSource knifeWhop;

    Animator amim;
    // Start is called before the first frame update
    void Start()
    {
        kn = GetComponent<Rigidbody2D>();
        amim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
   //   if (Input.GetMouseButtonDown(0))
        {
           
                amim.speed = 1f;
         //   Debug.Log("hi");
        //    knifeWhop.Play();

        }
 //     else { amim.speed = 0f; }
     if(kn.transform.position.y==-4)
        {
            Destroy(kn);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("police"))
        {
            float x = other.transform.position.x;
            float y = other.transform.position.y;

            Destroy(other.gameObject);
            Instantiate(bloodSplash,new Vector3(x-1f, y, 0f), Quaternion.identity);
           // other.gameObject.SetActive(false);
        }
        
       
    }
    
}
