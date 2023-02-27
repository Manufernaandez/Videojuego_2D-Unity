using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;

    public float doubleJumpSpeed = 2.5f;
    private bool canDoubleJump;

    Rigidbody2D rb2D;

    public bool betterJump = false;
    public float fallMultiplayer = 0.5f;
    public float lowJumpMultiplayer = 1f;

    public SpriteRenderer spriteRenderer;

    public Animator animator;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
       //Cuando se presiona la tecla de espacio
        if (Input.GetKey("space"))
        {
            if (CheckGround.isGrounded)
            {
                canDoubleJump = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            }
            else
            {
               //Para mejorar el salto
                if (Input.GetKeyDown("space"))
                {
                    if (canDoubleJump)
                    {
                        animator.SetBool("DoubleJump", true);
                        rb2D.velocity = new Vector2(rb2D.velocity.x, doubleJumpSpeed);
                        canDoubleJump=false;
                    }
                }
            }
        }

       //Si no detecta suelo, Player salta
        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
       //Si detecta suelo, Player no salta
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
            animator.SetBool("Fall", false);
        }

      //Para cuando estemos cayendo
       if (rb2D.velocity.y<0)
        {
            animator.SetBool("Fall", true);
        }
      //Para cuando estemos subiendo
        else if (rb2D.velocity.y>0)
        {
            animator.SetBool("Fall", false);
        }
    }
    
    void FixedUpdate()
    {
       //Al presionar la tecla "d" o la flecha que apunta a la derecha, Player se mueve hacia ese lado
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }

        //Al presionar la tecla "a" o la flecha que apunta a la izquierda, Player se mueve hacia ese lado
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            //Player se cambia de eje al girar
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }

        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

        //Salto doble al mantener la tecla espacio
        if (betterJump)
        {
            if (rb2D.velocity.y<0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplayer) * Time.deltaTime;
            }
            if (rb2D.velocity.y>0 && Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplayer) * Time.deltaTime;
            }
        }
    }
}
