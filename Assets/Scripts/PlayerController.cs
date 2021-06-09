using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float move;
    public Rigidbody2D rb;
    public bool isOnGrounded; 
    //bool isOnGrounded = false;
    public Transform Platform;
    public LoseManager loseManager;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    [SerializeField, Range(0, 30)] float moveSpeed = 0.5f;
    [SerializeField, Range(0, 30)] float jumpSpeed = 5;

    private Collider2D Collider;
    

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody for the player and the collider mainly for the platforms so they don't go through each other.
        rb = GetComponent<Rigidbody2D>();
        Collider = GetComponent<Collider2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move = moveSpeed;
        #region Code i didn't use
        /*
        if (Input.GetKey(KeyCode.Space) && currentStamina > 0)
        {
            move = move * jumpMulti;
            if (move != 0)
                currentStamina -= 2 * Time.deltaTime;
        }
        */
        /*
        else if (!Input.GetKey(KeyCode.Space) && currentStamina < maxStamina)
        {
            currentStamina += 1 * Time.deltaTime;
        }
        */
        /*
        if (Input.GetKeyCode(Space) && isOnGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        */
        #endregion
        // grounded position of the player landing on the platform
        isOnGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Jump Key
        if (Input.GetKeyDown(KeyCode.Space)) //&& isOnGrounded)
        {
            // if(isOnGrounded)
            //{
            // // Rigidbody velocity to determine the speed of the jump of the player
            // rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            // Debug.Log("Jump!");
            //}


            // Rigidbody velocity to determine the speed of the jump of the player
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
           Debug.Log("Jump!");
            
        }
        
        
    }
    private void FixedUpdate()
    {
        // determining the velocity for the players move speed
        rb.velocity = new Vector2(move, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // tag for the lose function
        if(other.gameObject.tag == "KillArea")
        {
            loseManager.RestartGame();
        }   
    }
    #region Code i also again didn't use
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isOnGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnGrounded = false;
    }
    */
    #endregion

}
