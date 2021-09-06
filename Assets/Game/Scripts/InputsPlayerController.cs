using UnityEngine;

public class InputsPlayerController : MonoBehaviour {

    public PlayerAnimationController playerAnimController;
    public PlayerController2D controller;
    public SpritePlayer spritePlayer;
    public PlayerTriggers playerTrigger;

    public bool isJump = false;
    float  horizontal;

    void Start() {

        playerAnimController=GetComponent<PlayerAnimationController>();
        controller=GetComponent<PlayerController2D>();
        spritePlayer=GetComponent<SpritePlayer>();
        playerTrigger=GetComponent<PlayerTriggers>();
    }

    public void Update() {

        horizontal = Input.GetAxis("Horizontal");

        controller.Move(horizontal);

        if (Input.GetButtonDown("Jump")) {

            controller.Jump();
        }

        if (horizontal > 0) {

            spritePlayer.FlipSprite(1);

        } else if (horizontal < 0) {

            spritePlayer.FlipSprite(-1);
        }

        if (!playerTrigger.isJump&&!isJump) {

            playerAnimController.SetAnimTrigger("Jump");
            isJump=true;
        }

        if (playerTrigger.isJump) {

            isJump=false;
        }

        playerAnimController.SetAnimBool("JumpExit", isJump);

        if (isJump) {
            return;
        }

        if (horizontal!=0) {

            playerAnimController.SetAnimTrigger("Run");

        } else {

            playerAnimController.SetAnimTrigger("Idle");

        }
    }

    public void FixedUpdate() {


    }
}
