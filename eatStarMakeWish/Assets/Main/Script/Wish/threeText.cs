using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class threeText : MonoBehaviour
{
    void Update()
    {
        if(Wish_write.count == 3){
            GetComponent<Text>().text = Wish_write.wishText;
            Wish_write.count = 0;
        }
    }
}
