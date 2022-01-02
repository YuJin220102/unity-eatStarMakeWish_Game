using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mintThree : MonoBehaviour
{
    void Update()
    {
        if(mint_Wish.count2 == 3){
            GetComponent<Text>().text = mint_Wish.wishText2;
            mint_Wish.count2 = 0;
        }
    }
}
