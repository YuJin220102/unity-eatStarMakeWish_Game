using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn6 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 53
        if(TotalScore.bnt6MaxScore >= 53){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt6MaxScore < 53 && TotalScore.bnt6MaxScore >= 43){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt6MaxScore < 43 && TotalScore.bnt6MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }

    public void btnSix(){
        TotalScore.T[5] += 1;
        MakeStar.time = 0.5f;
        TotalScore.btnClick = 6; // 스테이지 별로 계산
        Item1.stage = 6;
        SceneManager.LoadScene(2);
    }
}
