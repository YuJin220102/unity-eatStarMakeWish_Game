using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mintCoin : MonoBehaviour
{
    static public int mintcoin; 
    void Update()
    {
        GetComponent<Text>().text = mintcoin.ToString();
    }
}
