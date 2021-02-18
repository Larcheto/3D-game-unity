using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupButton : MonoBehaviour
{
    public GameObject button;
    void Start()
    {
        button.SetActive(false);
    }

    void OnTriggerEnter(Collider player){
        if(player.gameObject.tag=="Player"){
            button.SetActive(true);
        }
    }

}
