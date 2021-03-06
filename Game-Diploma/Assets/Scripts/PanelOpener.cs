﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public GameObject FirstButton;
    public GameObject SecondButton;
    
    public void OpenPanel(){
        if(Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            FirstButton.SetActive(false);
            SecondButton.SetActive(true);
        }
    }
}
