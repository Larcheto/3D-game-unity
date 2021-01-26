using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class move : MonoBehaviour  
{  
    Vector3 Vec;      
    public Animator animator;
    public float speed = 3;
    public void Move(){
        
         if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime*speed);  
            animator.SetBool("isWalking", true);

        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime*speed);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -10);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 10);  
        }  

    } 
    void Update(){ 
       animator.SetFloat("vertical", Input.GetAxis("Vertical")); 
       Move();
    }  
}  