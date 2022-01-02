using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn3 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 33
        if(TotalScore.bnt3MaxScore >= 33){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt3MaxScore < 33 && TotalScore.bnt3MaxScore >= 23){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt3MaxScore < 23 && TotalScore.bnt3MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }

    public void btnThree(){
        TotalScore.T[2] += 1;
        MakeStar.time = 0.8f;
        TotalScore.btnClick = 3; // 스테이지 별로 계산
        Item1.stage = 3;
        SceneManager.LoadScene(2);
    }
}
