using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item1 : MonoBehaviour
{
    static public int stage;
    public GameObject player;
    float timer1;
    float timer2;
    int rainClick;
    int hartClick;
    public GameObject btn1;
    public GameObject btn2;
    
    void Start() {
        // 아이템을 가지고 있을 때 화면에 보여줌
        if(starRainText.starRain >= 1){
            btn1.SetActive(true);
        }
        else{
            btn1.SetActive(false);
        }
        if(hartText.hart >= 1){
            btn2.SetActive(true);
        }
        else{
            btn2.SetActive(false);
        }

        rainClick = 0;
        hartClick = 0;
    }
// .......드디어 코루틴 성공
// 아이템 버튼을 연속으로 계속 누를 시 계속 지속됨..... 어케고쳐? 
 void Update() {
     if(rainClick == 1){ // 한 게임당 한번만 사용 가능!
         timer1 += Time.deltaTime; 
         if(5 > timer1){ // 5초 이하일 때는 0.1f
            StartCoroutine(rain());
        }
        else if(5 <= timer1){ // 5초 이상일 때는 1f
            if(stage == 1) MakeStar.time = 1f;
            if(stage == 2) MakeStar.time = 0.9f;
            if(stage == 3) MakeStar.time = 0.8f;
            if(stage == 4) MakeStar.time = 0.7f;
            if(stage == 5) MakeStar.time = 0.6f;
            if(stage == 6) MakeStar.time = 0.5f;
            btn1.SetActive(false); // 사용 후 버튼 삭제(코루틴 하는 도중에는 삭제 못함, 코루틴 안에도 x)
        }
     }

     if(hartClick == 1){
         timer2 += Time.deltaTime; 
        if(5 <= timer2){  // 5초 이상일 때는 캐릭터 크기 그대로 
            // 기존 크기 (0.493f, 0.493f, 0.493f), 기존 높이 (0, -3.25f, 0)
            Restoration();
        }
     }
}
    public void click1(){
        rainClick += 1; // 클릭 눌럿는지 확인하기 위해 사용
        starRainText.starRain -= 1; // 사용한 아이템 하나 삭제
        GetComponent<Button>().interactable = false;
    }
    public void click2(){ // 크기 3배로 
        hartClick += 1;
        player.transform.localScale = new Vector3(1.479f, 1.479f, 1.479f);
        player.transform.position = new Vector3(Palyer.position, -2.6f, 0);
        hartText.hart -= 1; // 사용한 아이템 하나 삭제
    }

    public void Restoration(){ // 크기 원상복구
        hartClick += 1;
        player.transform.localScale = new Vector3(0.493f, 0.493f, 0.493f);
        player.transform.position = new Vector3(Palyer.position, -3.25f, 0);
        
        btn2.SetActive(false); // 사용 후 버튼 삭제
    }

IEnumerator rain()
    {
        // 빠르게 별 내리기
         MakeStar.time = 0.1f;

        yield return null;
    }
}



// 코루틴 흔적,.......

// void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Space))
//         {
//             if(isDelay == false)
//             {
//                 isDelay = true;
//                 Debug.Log("HP가 50 회복 되었습니다.");
//                 StartCoroutine(Drink());
//             }
//             else
//             {
//                 Debug.Log("아직 포션을 사용할 수 없습니다.");
//                 MakeStar.time = 1f;
//             }
//         }
//     }



//yield return new WaitForSeconds(5.0f);
        // MakeStar.time = 0.1f;
        // isDelay = false;




    // // 코루틴? 찾아보기
    // public float time = 0;
    // static public int Click;
    // // private - 클래스 내부에서만 접근 가능
    // private Button btn;
    // void Start() {
    //     Click = 0;
        
    // }
    // void Update() {
    //     // if(Click == 1){
    //     //     item1_Click();
    //     // }
    // }
    // // ??????????????????????????????????????????????????
    // // ????????????????????????????????????????????????????????????????........................
    // //???????????????????????
    // //?????????????????????????????????????????
    // //????????? ?? ? ?  ? ???? ????????????///'''''''''''''??????????//????//?///?/?/????/
    // public void item1_Click(){
    //     Click = 0;
    //     MakeStar.time = 0.1f;
        // Click = 1;
        // time += Time.deltaTime;
        // Debug.Log("time" + time);
        // if(time < 6f){
        //      MakeStar.time = 0.1f;
        //      Debug.Log("if" + time);
        // }
        // else{
        //     GetComponent<Button>().interactable = false;
        //     //btn = item.transform.Find("Button").GetComponent<Button>();
        //     //btn.interactable = false; // 버튼 클릭을 비활성
        //     MakeStar.time = 0.9f;
        //     //Debug.Log("else" + time);
        // }
        // MakeStar.time = 0.9f;
    
// }
