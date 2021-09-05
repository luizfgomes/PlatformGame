using UnityEngine;

public class InputsPlayerController : MonoBehaviour {

    public PlayerAnimationController playerAnimController;
    public PlayerController2D controller;
    public SpritePlayer spritePlayer;

    void Start() {

        playerAnimController = GetComponent<PlayerAnimationController>();
        controller=GetComponent<PlayerController2D>();
        spritePlayer=GetComponent<SpritePlayer>();
    }

    public void Update() {

        var horizontal = Input.GetAxis("Horizontal");
        controller.Move(horizontal);

        if (horizontal>0) {
            spritePlayer.FlipSprite(1);
        } else if (horizontal<0) {
            spritePlayer.FlipSprite(-1);
        }

        if (Input.GetButtonDown("Jump")) {

            controller.Jump();
        }
    }
}
