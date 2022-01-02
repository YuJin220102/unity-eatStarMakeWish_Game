using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class twoText : MonoBehaviour
{
    void Update()
    {
        if(Wish_write.count == 2){
            GetComponent<Text>().text = Wish_write.wishText;
        }
    }
}
