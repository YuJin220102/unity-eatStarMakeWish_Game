using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mintOne : MonoBehaviour
{
    void Update()
    {
        if(mint_Wish.count2 == 1){
            GetComponent<Text>().text = mint_Wish.wishText2;
        }
    }
}
