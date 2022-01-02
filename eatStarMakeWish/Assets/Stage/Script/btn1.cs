using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn1 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 27
        if(TotalScore.bnt1MaxScore >= 27){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt1MaxScore < 27 && TotalScore.bnt1MaxScore >= 17){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt1MaxScore < 17 && TotalScore.bnt1MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }
    public void btnOne(){
        TotalScore.T[0] += 1;
        MakeStar.time = 1f; // 별이 떨어지는 속도
        TotalScore.btnClick = 1; // 스테이지 별로 계산
        Item1.stage = 1; // 아이템 속도 조절을 위해 
        SceneManager.LoadScene(2); // 게임 씬으로 
    }
}
