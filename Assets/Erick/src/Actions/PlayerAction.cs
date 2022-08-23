using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator anim;
    //Change the velocity parameter in inspector!
    public float velocity;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }
    void Update()
    {
        move();
    }
    void move() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * velocity;
        animation();
    }
    void animation() {
        if (movement.x != 0 || movement.y != 0)
        {
            anim.Play("Freeze");
        }
        else {
            anim.Play("Idle");
        }
    }
}
