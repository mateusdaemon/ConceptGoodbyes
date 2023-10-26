using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 direction;
    private float hor = 0;
    private float vert = 0;
    private Collider2D playerCol;
    private float colliderNegX;
    private float colliderPosX;

    public float swimForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        playerCol = GetComponent<Collider2D>();
        colliderNegX = -playerCol.offset.x;
        colliderPosX = playerCol.offset.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (Dialogue.GetIsDialoguing())
        {
            return;
        }

        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        direction.x = hor;
        direction.y = vert;

        if (hor < 0 )
        {
            sr.flipX = true;
            playerCol.offset = new Vector2(colliderNegX, playerCol.offset.y);
        } else if (hor > 0 )
        {
            sr.flipX = false;
            playerCol.offset = new Vector2(colliderPosX, playerCol.offset.y);
        }

        rb.AddRelativeForce(direction * swimForce);
    }
}
