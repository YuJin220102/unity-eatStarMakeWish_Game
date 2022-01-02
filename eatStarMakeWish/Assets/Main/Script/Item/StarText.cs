using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarText : MonoBehaviour
{
    
    static public int Star = 0;
    
    public void Update() {
        GetComponent<Text>().text = Star.ToString() + "개";
    }

}
