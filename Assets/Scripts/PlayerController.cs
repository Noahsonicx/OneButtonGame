using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float move;
    public Rigidbody2D rb;
    bool isOnGrounded;

    [SerializeField, Range(0, 30)] float moveSpeed = 5;
    [SerializeField, Range(0, 30)] float jumpSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move = moveSpeed;
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
        if (Input.GetKeyDown(KeyCode.Space) && isOnGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            Debug.Log("Jump!");
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isOnGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnGrounded = false;
    }
}
