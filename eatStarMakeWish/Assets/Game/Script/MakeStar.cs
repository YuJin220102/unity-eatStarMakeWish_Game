using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeStar : MonoBehaviour
{
    int [] obj = {-2, -1, 0, 1, 2, 3};
    public GameObject star;
    static public float time;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
        if(time <= timer){
            GameObject Makestar = Instantiate(star);
            Makestar.transform.position = new Vector3(obj[Random.Range(0,5)], 5.5f, 0);
            //Makestar.transform.position = new Vector3(obj[2], 5.5f, 0);
            timer = 0;
            Destroy(Makestar, 5);
        }
    }

}
