using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer : MonoBehaviour
{
     AudioSource sound;
    static public float right;
    static public float left;
    static public int Check = 0;
    static public int position;

    private void Start() {
        position = 0;
        sound = GetComponent<AudioSource>();
        sound.volume = sound2.Volume;
        if(Check >= 1) sound.volume = sound2.Volume;
        else sound.volume = 1f;

        right = 1;
        left = 1;
    }

    void Update()
    {
        Move();
    }
    public void Move(){
        if(Input.GetKeyDown(KeyCode.A)){
            transform.Translate(-left,0,0);
            position -= 1;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            transform.Translate(right,0,0);
            position += 1;
        }
    }
    public void leftBtn(){
        transform.Translate(-left, 0, 0);
        position -= 1;
    }
    public void rightBtn(){
        transform.Translate(right, 0, 0);
        position += 1;
    }
    private void OnTriggerStay2D(Collider2D other) {
        sound.Play();
    }

}
