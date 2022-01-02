using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wish_write : MonoBehaviour
{
    public static int count = 0;
    public GameObject openWish;
    public InputField Wish_Text;
    static public string wishText = "";

    public void wishClick(){
        openWish.SetActive(true);
    }

    public void wishBack(){
        Wish_Text.text = ""; // 입력 값 초기화
        openWish.SetActive(false);
    }

    public void Wish(){
        if(StarText.Star >= 1){
            count++;
            wishText = Wish_Text.text;
            Debug.Log(wishText);
            StarText.Star -= 1;
        }
        Wish_Text.text = "";
        openWish.SetActive(false);
    }
}
