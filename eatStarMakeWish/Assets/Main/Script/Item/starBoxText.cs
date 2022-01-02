using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starBoxText : MonoBehaviour
{
    static public int starBox = 0;
    public void Update() {
        GetComponent<Text>().text = starBox.ToString() + "개";
    }

}
