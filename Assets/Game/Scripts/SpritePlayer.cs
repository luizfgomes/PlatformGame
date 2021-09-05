using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePlayer : MonoBehaviour {

    public SpriteRenderer spriteRender;

    private void Start() {
        spriteRender=GetComponentInChildren<SpriteRenderer>();
    }

    public void FlipSprite(int x = 1) {
        spriteRender.gameObject.transform.localScale = new Vector3(x,1,1);
    }
}
