using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starRainText : MonoBehaviour
{
    static public int starRain = 0;
    public void Update() {
        GetComponent<Text>().text = starRain.ToString() + "개";
    }
}
