using UnityEngine;

public class PlayerTriggers : MonoBehaviour {

    public bool isJump=true;
    public bool isEnemyCollision=false;
    public float dist;

    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.tag =="Enemy") {

            isEnemyCollision=true;
            dist = Vector3.Distance(collision.transform.position, transform.position);

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
