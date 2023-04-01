using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;

    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }
        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
            onGround();
        }
    }

    public void onGround()
    {
        animator.SetBool("IsJumping", false);
    }
}