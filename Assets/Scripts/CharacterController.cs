using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {
    public float maxSpeed = 8f;
    private bool isFacingRight = true;
    private Animator anim;
    private Rigidbody2D rb;
    private GameObject player;
    private GameObject death;
    private GameObject pause;
    private GameObject reload;


    [SerializeField]
    private Transform[] groundPoint;
    [SerializeField]
    private float groundRadius;
    [SerializeField]
    private LayerMask whatIsGround;
    public static bool isGrounded = true;

    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<GameObject>();

        pause = GameObject.Find("Pause");
        reload = GameObject.Find("Reload");



        death = GameObject.Find("Dead");
        death.GetComponent<Image>().enabled = false;

    }
	

	void FixedUpdate () {

        isGrounded = IsGrounded();

       
        if (isGrounded == true)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }



        //float move = Input.GetAxis("Horizontal");
        float move = Input.acceleration.x;
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);
        

        if (move > 0 && !isFacingRight)
            Flip();
        else if (move < 0 && isFacingRight)
            Flip();
	}


    private void Flip () //пoворачивает персонажа в сторону ходьбы
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    } 


    void Update ()
    {
        
    }

    void OnBecameInvisible()
    {
        enabled = false;
        Debug.Log("THE GAME IS ENDED");

        death.GetComponent<Image>().enabled = true;
        pause.GetComponent<Image>().enabled = false;


        Time.timeScale = 0;


    }


    void OnBecameVisible()
    {
        enabled = true;
        
    }


    public void Reload()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;

        
    }

    


    public bool IsGrounded()
    {
        if (rb.velocity.y <= 0)
        {
            foreach (Transform point in groundPoint)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    var obj = colliders[i].gameObject;

                    if (obj != gameObject)
                    {
                        if (obj.tag == "Cloud")
                            GameObject.Destroy(obj, 0.25f);
                        return true;
                    }
                }
            }
        }
        return false;
    }

    
}
