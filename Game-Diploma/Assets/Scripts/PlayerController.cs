using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public ArrowMovement arrowMovement;
    public MouseRotation mouseRotation;
    
    void AnimateWalking(){
        animator.SetFloat("vertical", Input.GetAxis("Vertical")); 
    }
   
    void Update(){ 
        arrowMovement.Walk();
        mouseRotation.Rotate();
        AnimateWalking(); 
    }  
}