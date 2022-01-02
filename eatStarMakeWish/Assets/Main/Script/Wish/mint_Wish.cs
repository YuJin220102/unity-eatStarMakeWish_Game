using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mint_Wish : MonoBehaviour
{
    public static int count2 = 0;
    public GameObject openWish2;
    public InputField Wish_Text2;
    static public string wishText2 = "";

    public void wishClick(){
        openWish2.SetActive(true);
    }

    public void wishBack(){
        Wish_Text2.text = ""; // 입력 값 초기화
        openWish2.SetActive(false);
    }

    public void Wish(){
        if(mintCoin.mintcoin >= 10){
            count2++;
            wishText2 = Wish_Text2.text;
            Debug.Log(wishText2);
            mintCoin.mintcoin -= 10;
        }
        Wish_Text2.text = "";
        openWish2.SetActive(false);
    }
}
