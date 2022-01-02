using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    float speed = 3;
    // AudioSource sound;

    void Start()
    {
        // sound = GetComponent<AudioSource>();
        // sound.volume = sound2.Volume;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        }
    
        private void OnTriggerStay2D(Collider2D other) {
            Destroy(gameObject);
            Score.starScore += 1;
            //sound.Play();
            //  GetComponent<AudioSource>().Play();
        }
}
