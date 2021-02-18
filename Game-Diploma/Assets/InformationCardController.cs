using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;



public class InformationCardController : MonoBehaviour
{
    public Text Content;
    public Text Title;
    public int id = 1;
    
    //private string url = "http://localhost:3000/information-cards";

    public void OnButtonGetInfo(){
        StartCoroutine(GetCardById(id));
    }

    IEnumerator GetCardById(int id){
        
        string InformationCardURL = "http://localhost:3000/information-cards/1";

        UnityWebRequest InformationCardRequest = UnityWebRequest.Get(InformationCardURL);

        yield return InformationCardRequest.SendWebRequest();

        if( InformationCardRequest.isNetworkError || InformationCardRequest.isHttpError){
            Debug.LogError(InformationCardRequest.error);
            yield break;
        }

        JSONNode InformationCardInfo = JSON.Parse(InformationCardRequest.downloadHandler.text);
        string title = InformationCardInfo["title"];
        string content = InformationCardInfo["content"];

        Content.text = content;
        Title.text = title;
     }

  
}
