using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour {

    public bool isJump;

    void OnTriggerStay2D(Collider2D collision) {

        if (collision.tag =="Floor") {

            isJump=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.tag=="Floor") {

            isJump=false;
        }
    }
}
