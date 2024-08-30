using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static PlayerStamina;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] int jumpForce;
    [SerializeField] int jumpStaminaCost;

    Rigidbody2D rb;
    bool facingRight = true;
    float moveDirection;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
            
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        moveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        if (playerStamina.currentStamina < jumpStaminaCost)
        {
            return;
        }

        playerStamina.LoseStamina(jumpStaminaCost);
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
