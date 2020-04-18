/*
 * Kevon Long
 * Player.cs
 * Assignment #11
 * handles the player jumping and triggering the other objects, as well as the win and loss text
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    public GameObject door;
    public bool canJump;
    public GameObject wintext;
    public GameObject loseText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "key")
        {
            door.SetActive(false);
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag == "goal")
        {
            WinGame();
        }
        else if (collision.gameObject.tag == "spike")
        {
            LoseGame();
            Debug.Log("lose");
        }
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded() && canJump)
        {
            float jumpVelocity = 15f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 1f, platformLayerMask);
        return raycastHit2d.collider != null;
    }

    public void SetJump(bool canJump)
    {
        this.canJump = canJump;
    }

    public void LoseGame()
    {
        GameFacade.gameStatus = false;
        loseText.SetActive(true);
    }

    public void WinGame()
    {
        GameFacade.gameStatus = false;
        wintext.SetActive(true);
    }

}
