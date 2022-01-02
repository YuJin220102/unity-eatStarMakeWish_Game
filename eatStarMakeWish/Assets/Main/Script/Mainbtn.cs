using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainbtn : MonoBehaviour
{
    public Typebtn click;
    public CanvasGroup Main;
    public CanvasGroup Option; 
    public CanvasGroup Store;
    public CanvasGroup Wish;
    public CanvasGroup Instructions;

    public void BtnClick(){
        switch(click){
            case Typebtn.OPTION:
                ON(Option);
                OFF(Main);
                break;

            case Typebtn.STORE:
                ON(Store);
                OFF(Main);
                break;

            case Typebtn.WISH:
                ON(Wish);
                OFF(Main);
                break;

            case Typebtn.INSTRUCTIONS:
                ON(Instructions);
                OFF(Main);
                break;

            case Typebtn.EXIT:
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
                break;

            case Typebtn.OPTION_BACK:
                ON(Main);
                OFF(Option);
                break;

            case Typebtn.STORE_BACK:
                ON(Main);
                OFF(Store);
                break;

            case Typebtn.WISH_BACK:
                ON(Main);
                OFF(Wish);
                break;

            case Typebtn.INSTRUCTIONS_BACK:
                ON(Main);
                OFF(Instructions);
                break;
        }
    }

    public void ON(CanvasGroup cg){
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    public void OFF(CanvasGroup cg){
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
}
