using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    void Start() {
        TotalScore.totalCoin +=  300;
    }

    void Update()
    {
        GetComponent<Text>().text = TotalScore.totalCoin.ToString();
    }
    
}
