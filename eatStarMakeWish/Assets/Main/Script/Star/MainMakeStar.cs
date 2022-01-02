using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMakeStar : MonoBehaviour
{

    int [] obj = {-3, -2, -1, 0, 1, 2, 3};
    public GameObject Star0;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    float time;
    float timer = 0;
    int ran;
    // Start is called before the first frame update
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ran = Random.Range(0,4);
        timer += Time.deltaTime;
        if(ran == 0){
            if(time <= timer){
                GameObject Star0_0 = Instantiate(Star0);
                Star0_0.transform.position = new Vector3(obj[Random.Range(0,6)], 5.5f, 0);
                timer = 0;
                Destroy(Star0_0, 5);
            }
        }
        if(ran == 1){
            if(time <= timer){
                GameObject Star1_1 = Instantiate(Star1);
                Star1_1.transform.position = new Vector3(obj[Random.Range(0,6)], 5.5f, 0);
                timer = 0;
                Destroy(Star1_1, 5);
            }
        }
        if(ran == 2){
            if(time <= timer){
                GameObject Star2_2 = Instantiate(Star2);
                Star2_2.transform.position = new Vector3(obj[Random.Range(0,6)], 5.5f, 0);
                timer = 0;
                Destroy(Star2_2, 5);
            }
        }
        if(ran == 3){
            if(time <= timer){
                GameObject Star3_3 = Instantiate(Star3);
                Star3_3.transform.position = new Vector3(obj[Random.Range(0,6)], 5.5f, 0);
                timer = 0;
                Destroy(Star3_3, 5);
            }
        }
        
    }
}
