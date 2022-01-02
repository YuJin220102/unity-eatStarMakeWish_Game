using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishBtn : MonoBehaviour
{
    public GameObject Wish1;
    public GameObject Wish2;

//??????????????왜 안댐?? 
// 바보짓한듯
    public void btn1(){
        Wish1.SetActive(true);
        Wish2.SetActive(false);
    }

    public void btn2(){
        Wish1.SetActive(false);
        Wish2.SetActive(true);
    }
    
}
