using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour {

    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Rigidbody2D rig2D;

    public int speed;
    public int jumpSpeed;

    private void Start() {

        render=GetComponentInChildren<SpriteRenderer>();
        rig2D=GetComponentInChildren<Rigidbody2D>();
    }

    public Vector2 Move(float setWay) {

        return rig2D.velocity=new Vector2(speed * setWay, rig2D.velocity.y);
    }

    public void Jump() {

        rig2D.velocity=new Vector2(0, jumpSpeed);
    }
}
