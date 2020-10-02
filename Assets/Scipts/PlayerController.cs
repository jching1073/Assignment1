using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables

    private Rigidbody2D rbody;
    private bool isGrounded = false;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float jumpForce = 500.0f;
    [SerializeField] private float groundCheckRadius = 0.15f;
    [SerializeField] private Transform groundGcheckPos;
    [SerializeField] private LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

  
    //physics
    private void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        isGrounded = GroundCheck();

        // jump code

        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            rbody.AddForce(new Vector2(0.0f, jumpForce));
            isGrounded = false;
        }
        rbody.velocity = new Vector2(horiz * speed, rbody.velocity.y);
    }

    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundGcheckPos.position, groundCheckRadius, whatIsGround);
        
    }
}
