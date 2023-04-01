using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;
    float movement; 

    float horizontalmove;

    SpriteRenderer sr;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

        horizontalmove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));

        sr.flipX = movement < 0 ? true : false;
 
    }
    
}
