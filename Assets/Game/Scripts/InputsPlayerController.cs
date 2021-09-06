using UnityEngine;
using System.Collections;


public class InputsPlayerController : MonoBehaviour {

    public PlayerAnimationController playerAnimController;
    public PlayerController2D controller;
    public SpritePlayer spritePlayer;
    public PlayerTriggers playerTrigger;

    public bool isJump = false;
    float  horizontal;

    public bool isHurt;

    void Start() {

        playerAnimController=GetComponent<PlayerAnimationController>();
        controller=GetComponent<PlayerController2D>();
        spritePlayer=GetComponent<SpritePlayer>();
        playerTrigger=GetComponent<PlayerTriggers>();

        isHurt=false;
    }

    public void Update() {

        horizontal = Input.GetAxis("Horizontal");
        
        if (playerTrigger.isEnemyCollision && !isHurt) {

            isHurt=true;
            StartCoroutine(PlayerHurt());
            playerAnimController.SetAnimTrigger("Hurt");
        }

        if (isHurt)
            return;

        controller.Move(horizontal);

        if (Input.GetButtonDown("Jump")) {

            controller.Jump();
        }

        FlipPlayer();

        AnimationControllerWithInputs();
    }


    void EnemyCollision() {

        StartCoroutine(PlayerHurt());
    }

    void FlipPlayer() {

        if (horizontal>0) {

            spritePlayer.FlipSprite(1);

        } else if (horizontal<0) {

            spritePlayer.FlipSprite(-1);
        }
    }

    void AnimationControllerWithInputs() {

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

    IEnumerator PlayerHurt() {

        controller.Hurt(5, playerTrigger.dist);
        yield return new WaitForSeconds(0.5f);

        isHurt=false;
    }
}
