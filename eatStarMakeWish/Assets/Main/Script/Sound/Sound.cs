using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // 노래 중복 겹침 현상 고치기 - 완료
    // 처음화면 돌아갈때마다 슬라이더 Fill 값이 처음으로 돌아감..
    GameObject BackgroundMusic;
    public AudioSource musicsource;
    public void SetMusicVolume(float volume){
        musicsource.volume = volume;
    }

    void Awake() {
        BackgroundMusic = GameObject.Find("oneAudioSource");
        musicsource = BackgroundMusic.GetComponent<AudioSource>(); // 배경음악 저장
        if(musicsource.isPlaying)return; // 배경음악이 재생되고 있다면 패스
        else{
            musicsource.Play();
            DontDestroyOnLoad(musicsource); // scene을 이동해도 오브젝트 사라지지 않음
        }
    }
    //https://foxtrotin.tistory.com/129 참조
}
