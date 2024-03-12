using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public bool isGrounded;
    public float maxSpeed = 5f;
    public bool isDead;
    public GameObject DeadUX;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(transform.up * jumpForce * 1000 *  Time.deltaTime);
            
            CapRigidbodySpeed();
        }
    }
    private void CapRigidbodySpeed()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            isGrounded = true;
        }

        if (other.tag == "Laser")
        {
            //dead
            isDead = true;
            DeadUX.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
