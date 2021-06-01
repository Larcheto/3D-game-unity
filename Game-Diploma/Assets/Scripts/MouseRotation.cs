using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    public Transform cameraHolder;
    private float mouseSensitivity = 2f;

    public void Rotate(){
        float rotation = Input.GetAxis("Mouse X");
        
        transform.Rotate(0, rotation * mouseSensitivity, 0);
        Vector3 currentRotation = cameraHolder.localEulerAngles;
    }
}
