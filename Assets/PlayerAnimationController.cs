
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {

    [SerializeField] private Animator anim;

    void Start() {

        anim=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    public void SetAnimTrigger(string trigger) {
        anim.SetTrigger(trigger);
    }

    public void SetAnimBool(string animName, bool isSetAnim) {
        anim.SetBool(animName, isSetAnim);
    }
}
