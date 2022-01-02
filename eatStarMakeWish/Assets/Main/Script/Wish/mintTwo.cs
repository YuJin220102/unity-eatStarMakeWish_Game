using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mintTwo : MonoBehaviour
{
    void Update()
    {
        if(mint_Wish.count2 == 2){
            GetComponent<Text>().text = mint_Wish.wishText2;
        }
    }
}
