using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class write : MonoBehaviour
{
    public static int count = 0;
    public GameObject openWish;
    public InputField Wish_Text;
    static public string wishText = "";

    string oneWish;

    public void wishClick(){
        openWish.SetActive(true);
    }

    public void wishBack(){
        Wish_Text.text = ""; // 입력 값 초기화
        openWish.SetActive(false);
    }

    public void Wish(){
        count++;
        if(count == 1){
            Wishone();
        }
        if(count == 2){
            GetComponent<Text>().text = Wish_Text.text;
        }
        if(count == 3){
            GetComponent<Text>().text = Wish_Text.text;
            count = 0;
        }
        Wish_Text.text = "";
    }
    public void Wishone(){
        GetComponent<Text>().text = oneWish;
    }
}
