using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollisioin : MonoBehaviour
{
    [SerializeField] private NewScene newScene;

    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.tag =="Player") {

            newScene.Scene();
        }
    }
}
