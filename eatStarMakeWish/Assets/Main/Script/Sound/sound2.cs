using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound2 : MonoBehaviour
{
    public AudioSource musicsource2;
    static public float Volume;

    public void SetMusicVolume2(float volume){
        musicsource2.volume = volume;
        Volume = musicsource2.volume; // 볼륨값 저장
        Palyer.Check += 1;
    }

    void Start() {
        // DontDestroyOnLoad는 scene을 이동해도 오브젝트 사라지지 않음
        DontDestroyOnLoad(musicsource2);
    }
}
