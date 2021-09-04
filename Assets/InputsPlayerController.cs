using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputsPlayerController : MonoBehaviour {

    public PlayerAnimationController playerAnimController;
    public PlayerController2D controller;

    void Start() {

        playerAnimController = GetComponent<PlayerAnimationController>();
        controller=GetComponent<PlayerController2D>();
    }

    public void Update() {

        var horizontal = Input.GetAxis("Horizontal");
        controller.Move(horizontal);
        if (horizontal != 0) {

            
        }

        if (Input.GetButtonDown("Jump")) {

            controller.Jump();
        }
    }

    
}
