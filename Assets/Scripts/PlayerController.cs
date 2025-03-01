using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;//Movimiento

    public bool canDoubleeJump;

    public float jumpForce;//Salto

    public Rigidbody2D theRB;//Componentes

    private bool isGrounded;

    public Transform groundCheckpoint;//Deteccion de suelo

    public LayerMask whatIsGround;

    void Start()
    {

    }


    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, 2f, whatIsGround);
        if (isGrounded)
        {
            canDoubleeJump = true;

            if (Input.GetButtonDown("Jump"))
            {
                if (isGrounded)
                {
                    theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                }
                else
                {
                    if (canDoubleeJump)
                    {
                        theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
                        canDoubleeJump = false;
                    }
                }
            }
        }
    }
}
