using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class oneText : MonoBehaviour
{

    void Update()
    {
        if(Wish_write.count == 1){
            GetComponent<Text>().text = Wish_write.wishText;
            // Replace = 필요한 문자열 변경 (공백)
            // string.Empty = 빈 문자열로 대체
            Wish_write.wishText.Replace(" ", string.Empty);
            if(Wish_write.wishText.Length <= 26) 
                GetComponent<Text>().fontSize = 25;
            else if(Wish_write.wishText.Length <= 51 && Wish_write.wishText.Length > 26)
                GetComponent<Text>().fontSize = 20;
        }
    }
}
