using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn5 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    // Start is called before the first frame update
    void Start()
    { // 최대 44
        if(TotalScore.bnt5MaxScore >= 44){
            star1.SetActive(true); // SetActive 특정 오브젝트 on/off
            star2.SetActive(true);
            star3.SetActive(true);
        }
        else if(TotalScore.bnt5MaxScore < 44 && TotalScore.bnt5MaxScore >= 34){
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        else if(TotalScore.bnt5MaxScore < 34 && TotalScore.bnt5MaxScore >= 1){
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
    }

    public void btnFive(){
        TotalScore.T[4] += 1;
        MakeStar.time = 0.6f;
        TotalScore.btnClick = 5; // 스테이지 별로 계산
        Item1.stage = 5;
        SceneManager.LoadScene(2);
    }
}
