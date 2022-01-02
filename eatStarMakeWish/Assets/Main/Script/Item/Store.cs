using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public GameObject Ok;
    private void Start() {
    }

    public void starBtn(){
        if(TotalScore.totalCoin >= 100){ // 코인 100개 보유 이상일 때
            Ok.SetActive(true); // 확인창 켜줌
            StoreOk.StarOk = 1;
        } // 구매 불가 버튼 만들기
    }
    public void hartBtn(){
        if(TotalScore.totalCoin >= 10){
            Ok.SetActive(true);
            StoreOk.hartOk = 1;
        }
    }
    public void starRainBtn(){
        if(TotalScore.totalCoin >= 25){
            Ok.SetActive(true);
            StoreOk.starRainOk = 1;
        }
    }
    public void starBoxBtn(){
        Ok.SetActive(true);
        StoreOk.starBoxOk = 1;
    }

}
