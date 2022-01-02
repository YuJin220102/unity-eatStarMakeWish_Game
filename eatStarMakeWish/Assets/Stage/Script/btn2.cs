using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn2 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 30
        if(TotalScore.bnt2MaxScore >= 30){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt2MaxScore < 30 && TotalScore.bnt2MaxScore >= 20){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt2MaxScore < 20 && TotalScore.bnt2MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }

    public void btnTwo(){
        TotalScore.T[1] += 1;
        MakeStar.time = 0.9f;
        TotalScore.btnClick = 2; // 스테이지 별로 계산
        Item1.stage = 2;
        SceneManager.LoadScene(2);
    }
}
