using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloser : MonoBehaviour
{
    public GameObject Panel;
    public GameObject SecondButton;
    
    public void ClosePanel(){
        if(Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
            SecondButton.SetActive(false);
        }
    }
}
