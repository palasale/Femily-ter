using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Health = 10;
    public float Speed = 1;
    public GameObject explosionPrefab;
    private Rigidbody2D rigidBody2D;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        var unitController = other.gameObject.GetComponent<UnitController>();
        if (unitController)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            if (--Health <= 0)
            {
                Instantiate(explosionPrefab, transform.position, transform.rotation);
                Instantiate(explosionPrefab, transform.position, transform.rotation);
                Instantiate(explosionPrefab, transform.position, transform.rotation);
                Instantiate(explosionPrefab, transform.position, transform.rotation);
                Instantiate(explosionPrefab, transform.position, transform.rotation);
                Destroy(this.gameObject);
            }
        }
        
    }

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }


    public void Update()
    {
        if (Input.anyKey)
        {
            if( Input.GetKey(KeyCode.D))
            {
                rigidBody2D.velocity = Vector2.right * Speed;
            }

            if( Input.GetKey(KeyCode.A))
            {
                rigidBody2D.velocity = Vector2.left * Speed;
            }
            
        }
        else
        {
            rigidBody2D.velocity = Vector2.zero;
        }
    }
}
