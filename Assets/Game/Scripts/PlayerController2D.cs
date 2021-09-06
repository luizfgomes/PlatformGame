using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour {

    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private PlayerTriggers playerTriggers;

    public int speed;
    public int jumpSpeed;

    private void Start() {

        render=GetComponentInChildren<SpriteRenderer>();
        rb2D=GetComponentInChildren<Rigidbody2D>();
        playerTriggers=GetComponentInChildren<PlayerTriggers>();
    }

    public Vector2 Move(float setWay) {

        return rb2D.velocity = new Vector2(speed * setWay, rb2D.velocity.y);
    }

    public void Jump() {

        if (playerTriggers.isJump)
            rb2D.velocity=new Vector2(0, jumpSpeed);
    }

    public void Hurt() {

        rb2D.velocity=new Vector2(-5, 5);
    }
}
