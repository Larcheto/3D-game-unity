using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizOpener : MonoBehaviour
{
    public void OpenQuiz(){
         Application.OpenURL("http://localhost:5000/");
    }
}
