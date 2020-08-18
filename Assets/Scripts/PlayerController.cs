﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public Transform groundPoint;
    
    public LayerMask groundLayer;
    public bool grounded;
    public float yVelocity;
    public int jumpForce;
    public Transform effectPosition;
    public GameObject deathEffect;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapPoint(groundPoint.position, groundLayer);
    }
    // Update is called once per frame
    void Update()
    {
        if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
            rb.AddForce(Vector2.up * jumpForce);

        }
        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("Grounded", grounded);
            
    }

    public void gameOver()
    {
        Instantiate(deathEffect, effectPosition.position, Quaternion.identity);
        GameOver.SetActive(true);
        Destroy(gameObject);
    }
}
