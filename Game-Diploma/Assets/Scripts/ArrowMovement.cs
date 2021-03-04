using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  

  
public class ArrowMovement : MonoBehaviour  
{     
    public float speed = 3;

    public void Walk(){
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime*speed);  
        }  
         if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))  
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
}  