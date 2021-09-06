using UnityEngine;

public class PlayerTriggers : MonoBehaviour {

    public bool isJump=true;
    public bool isEnemyCollision=false;

    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.tag =="Enemy") {

            isEnemyCollision=true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision) {

        if (collision.tag =="Floor") {

            isJump=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag=="Floor") {

            isJump=false;
        }

        if (collision.tag=="Enemy") {

            isEnemyCollision=false;
        }
    }
}
