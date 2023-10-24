using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float playerSpeed = 0.5f;
    public bool orientToDirection = false;
    private SpriteRenderer sprRend;
    private Rigidbody2D rb;
    private float movementInputX = 0;
    private Vector3 direction;

    void Start()
    {
        sprRend = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // When dialoguing Player can`t move
        if (Dialogue.GetIsDialoguing())
        {
            return;
        }

        movementInputX = Input.GetAxisRaw("Horizontal");

        if (movementInputX < 0 && orientToDirection)
        {
            sprRend.flipX = true;
        } else if (movementInputX > 0 && orientToDirection)
        {
            sprRend.flipX = false;
        }

        direction = new Vector3(movementInputX, 0);

        // deltaTime is used to syinc player speed with screen framerate
        //direction *= (playerSpeed * Time.deltaTime);

        rb.AddForce(direction * playerSpeed);

    }
}
