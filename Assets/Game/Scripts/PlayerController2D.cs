using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController2D : MonoBehaviour {

    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private PlayerTriggers playerTriggers;
    [SerializeField] private NewScene newScene;

    public int speed;
    public int jumpSpeed;

    public static int life;

    private void Start() {

        render=GetComponentInChildren<SpriteRenderer>();
        rb2D=GetComponentInChildren<Rigidbody2D>();
        playerTriggers=GetComponentInChildren<PlayerTriggers>();
        newScene=GameObject.FindGameObjectWithTag("Controller").GetComponent<NewScene>();
        life =3;
    }

    private void Update() {
        if (life == 0) {
            StartCoroutine(Death());
        }
    }

    public Vector2 Move(float setWay) {

        return rb2D.velocity = new Vector2(speed * setWay, rb2D.velocity.y);
    }

    public void Jump() {

        if (playerTriggers.isJump)
            rb2D.velocity=new Vector2(0, jumpSpeed);
    }

    public void Hurt(float value = 5, float setWay = 1) {
        
        if(setWay > 1)
            rb2D.velocity=new Vector2(-value, value);
        else
            rb2D.velocity=new Vector2(value, value);
    }

    IEnumerator Death() {

        yield return new WaitForSeconds(5f);

        newScene.Scene();
    }
}
