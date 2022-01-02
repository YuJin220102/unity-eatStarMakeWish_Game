using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class moveScenes : MonoBehaviour
{
    public void Home(){
        SceneManager.LoadScene(0);
    }
    public void stayge(){
        SceneManager.LoadScene(1);
    }
    public void rePlay(){
        SceneManager.LoadScene(2);
    }
}
