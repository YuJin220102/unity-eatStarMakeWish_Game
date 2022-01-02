using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreOk : MonoBehaviour
{
    public GameObject CancelObj;
    static public int StarOk;
    static public int hartOk;
    static public int starRainOk;
    static public int starBoxOk;
    public void Ok(){
        if(StarOk == 1){  // 아이템 별 무엇을 눌럿는지 확인
            StarText.Star += 1; // 구매 갯수 늘려 줌
            StarOk = 0; // 누른거 초기화 시키기
            TotalScore.totalCoin -= 100; // 현재 가지고 있는 코인에서 구매 값 빼기
            CancelObj.SetActive(false); // 구매창 닫기
        }
        if(hartOk == 1){
            hartText.hart += 1;
            hartOk = 0;
            TotalScore.totalCoin -= 10;
            CancelObj.SetActive(false);
        }
        if(starRainOk == 1){
            starRainText.starRain += 1;
            starRainOk = 0;
            TotalScore.totalCoin -= 25;
            CancelObj.SetActive(false);
        }
        if(starBoxOk == 1){
            starBoxText.starBox += 1;
            starBoxOk = 0;
            CancelObj.SetActive(false);
        }
    }
    public void Cancel(){
        CancelObj.SetActive(false);
        StarOk = 0;
        hartOk = 0;
        starRainOk = 0;
        starBoxOk = 0;
    }
}
