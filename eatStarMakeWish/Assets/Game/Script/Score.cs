using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int starScore;
    // Start is called before the first frame update
    void Start()
    {
        starScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = starScore.ToString();
    }
}
