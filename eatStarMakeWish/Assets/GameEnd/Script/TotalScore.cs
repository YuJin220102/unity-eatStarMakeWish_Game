using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalScore : MonoBehaviour
{
    // 코인 계산 ( 씬 이동할 시 초기화 되서 public static하여 보관해줌 )
    public static int[] maxCoin = {0, 0, 0, 0, 0, 0};
    public static int[] minCoin = {0, 0, 0, 0, 0, 0};
    // 총 코인 합
    static public int totalCoin = 0;
    // 게임 한판 했는지
    static public int[] T = {0, 0, 0, 0, 0, 0};

    // 스테이지 몇을 눌럿는지
    static public int btnClick;
    // 최대 점수 값 저장
    static public int bnt1MaxScore = 0;
    static public int bnt2MaxScore = 0;
    static public int bnt3MaxScore = 0;
    static public int bnt4MaxScore = 0;
    static public int bnt5MaxScore = 0;
    static public int bnt6MaxScore = 0;

    // 먹은 별의 개수별 오브젝트 띄우기 
    public GameObject star2;
    public GameObject star3;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = Score.starScore.ToString();

        // 배열로 고치자!
        // 스테이지 1을 눌럿을 때 (최대 27개임)
        if(btnClick == 1){
            minCoin[0] = Score.starScore; // 코인 계산용

            Debug.Log("T[0] " + T[0]);
            // 게임 끝났을때 보여주는 별 계산
            if(Score.starScore >= 27){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 27 && Score.starScore >= 17){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
                // 최고값을 찍었을 때만 저장 (스테이지 별 계산)
            if(bnt1MaxScore <= Score.starScore){
                bnt1MaxScore = Score.starScore;
                }
                // 코인 계산 ( 기존 - 더 먹은 값만 ) 못하겠엉.. (완료)
            if(T[0] == 1){ // 게임 한번 돌렷을 때
                maxCoin[0] = minCoin[0];
                totalCoin += maxCoin[0];
                Debug.Log("else " + totalCoin);
            }
            if(T[0] > 1){ // 한번 이상 돌렷을 때
                if(maxCoin[0] < minCoin[0]){ // minCoin이 더 크다면
                totalCoin += (minCoin[0] - maxCoin[0]); // 총 코인의 합 계산
        
                maxCoin[0] = minCoin[0]; // maxCoin에 넣어주고
                Debug.Log("if" + totalCoin);
                }
            }
        }
        
        // 스테이지 2을 눌럿을 때 (최대 30개임)
        if(btnClick == 2){
            minCoin[1] = Score.starScore;

            if(Score.starScore >= 30){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 30 && Score.starScore >= 20){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
            if(bnt2MaxScore <= Score.starScore){
                bnt2MaxScore = Score.starScore;
                }
            if(T[1] == 1){
                maxCoin[1] = minCoin[1];
                totalCoin += maxCoin[1];
            }
            if(T[1] > 1){ 
                if(maxCoin[1] < minCoin[1]){
                totalCoin += (minCoin[1] - maxCoin[1]); 
        
                maxCoin[1] = minCoin[1]; 
                }
            }
        }

        // 스테이지 3을 눌럿을 때 (쵀대 33개임)
        if(btnClick == 3){
            minCoin[2] = Score.starScore;

            if(Score.starScore >= 33){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 33 && Score.starScore >= 23){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
            if(bnt3MaxScore <= Score.starScore){
                bnt3MaxScore = Score.starScore;
                }
            if(T[2] == 1){
                maxCoin[2] = minCoin[2];
                totalCoin += maxCoin[2];
            }
            if(T[2] > 1){ 
                if(maxCoin[2] < minCoin[2]){
                totalCoin += (minCoin[2] - maxCoin[2]); 
        
                maxCoin[2] = minCoin[2]; 
                }
            }
        }
        // 스테이지 4을 눌럿을 때 (쵀대 38개임)
        if(btnClick == 4){
            minCoin[3] = Score.starScore;

            if(Score.starScore >= 38){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 38 && Score.starScore >= 28){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
            if(bnt4MaxScore <= Score.starScore){
                bnt4MaxScore = Score.starScore;
                }
            if(T[3] == 1){
                maxCoin[3] = minCoin[3];
                totalCoin += maxCoin[3];
            }
            if(T[3] > 1){ 
                if(maxCoin[3] < minCoin[3]){
                totalCoin += (minCoin[3] - maxCoin[3]); 
        
                maxCoin[3] = minCoin[3]; 
                }
            }
        }
        // 스테이지 5을 눌럿을 때 (쵀대 44개임)
        if(btnClick == 5){
            minCoin[4] = Score.starScore;

            if(Score.starScore >= 44){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 44 && Score.starScore >= 34){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
            if(bnt5MaxScore <= Score.starScore){
                bnt5MaxScore = Score.starScore;
                }
            if(T[4] == 1){
                maxCoin[4] = minCoin[4];
                totalCoin += maxCoin[4];
            }
            if(T[4] > 1){ 
                if(maxCoin[4] < minCoin[4]){
                totalCoin += (minCoin[4] - maxCoin[4]); 
        
                maxCoin[4] = minCoin[4]; 
                }
            }
        }
        // 스테이지 6을 눌럿을 때 (쵀대 53개임) 
        if(btnClick == 6){
            minCoin[5] = Score.starScore;

            if(Score.starScore >= 53){
                star2.SetActive(true); // SetActive 특정 오브젝트 on/off
                star3.SetActive(true);
                }
            else if(Score.starScore < 53 && Score.starScore >= 43){
                star2.SetActive(true);
                star3.SetActive(false);
                }
            else{
                star2.SetActive(false);
                star3.SetActive(false);
                }
            if(bnt6MaxScore <= Score.starScore){
                bnt6MaxScore = Score.starScore;
                }
            if(T[5] == 1){
                maxCoin[5] = minCoin[5];
                totalCoin += maxCoin[5];
            }
            if(T[5] > 1){ 
                if(maxCoin[5] < minCoin[5]){
                totalCoin += (minCoin[5] - maxCoin[5]); 
        
                maxCoin[5] = minCoin[5]; 
                }
            }
        }
    } 
}

