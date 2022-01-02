using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    public float num;

    void Start() {
        //Time.timeScale = 1; // 일시정지 풂
    }

    // Update is called once per frame
    void Update()
    {    
        
        if(num <= 0.99f){
            //Time.timeScale = 0; // 화면 일시정지
            SceneManager.LoadScene(3);
        }
        
        // 소수점 없애기 위해 Mathf.Floor 사용
        GetComponent<Text>().text = Mathf.Floor(num).ToString();
        num -= Time.deltaTime;
        
    }
    // 게임 종료 시 점점 어두워 지게 할려다 실패,,
    // public void Gradient(){
    //         GameObject goImage = GameObject.Find("Canvas/Gradient");
    //         Color color = goImage.GetComponent<Image>().color;
    //         for(int i = 0; i < 100; i++){
    //             color.a += Time.deltaTime * 0.01f;
    //             goImage.GetComponent<Image>().color = color;
    //         }  
    // }
}
