using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hartText : MonoBehaviour
{
    static public int hart = 0;
    public void Update() {
        GetComponent<Text>().text = hart.ToString() + "개";
    }
}
