using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn4 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 38
        if(TotalScore.bnt4MaxScore >= 38){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt4MaxScore < 38 && TotalScore.bnt4MaxScore >= 28){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt4MaxScore < 28 && TotalScore.bnt4MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }

    public void btnFour(){
        TotalScore.T[3] += 1;
        MakeStar.time = 0.7f;
        TotalScore.btnClick = 4; // 스테이지 별로 계산
        Item1.stage = 4;
        SceneManager.LoadScene(2);
    }
}
