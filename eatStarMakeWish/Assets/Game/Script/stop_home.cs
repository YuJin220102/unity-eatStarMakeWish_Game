using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class stop_home : MonoBehaviour
{
    public GameObject stopBtn;
    public GameObject playBtn;

    public void stop(){
        stopBtn.SetActive(false);
        playBtn.SetActive(true);
        
        Palyer.right = 0f;
        Palyer.left = 0f;

        Time.timeScale = 0;
    }
    public void home(){
        SceneManager.LoadScene(0);
    }
    public void play(){
        stopBtn.SetActive(true);
        playBtn.SetActive(false);

        Palyer.right = 1f;
        Palyer.left = 1f;

        Time.timeScale = 1;
    }
}
