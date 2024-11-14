using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioType{
    BGM,
    SFX,
}
[System.Serializable]

public class AudioObject{
    public string id;
    public AudioType type;
    public AudioClip clip;
}

private static AudioManager _instance;
public static AudioManager instance{
    get{
        if( _instance == null){
            _instance = GameObject.FindObjectOfType <AudioManager>;
        }
    }
}

public class AudioManager : MonoBehaviour
{
    public AudioSource audiosourceBGM;
    public AudioSource audiosourceSFX;
    public List<AudioObject> AudioObjects;

    public void PlayAudio(AudioType _type, string _id){
    switch(_type){
        case AudioType.BGM:
            //ESCRIBIR EL CODIGO PARA REPRODUCIR BGM
            audiosourceBGM.clip = SearchAudioClip(_id);
            audiosourceBGM.Play();
            break;
        case AudioType.SFX:
            //ESCRIBIR EL CODIGO PARA REPRODUCIR BGM
            audiosourceSFX.clip = SearchAudioClip(_id);
            audiosourceSFX.Play();
            break;
        }

    private AudioClip SearchAudioClip(string _id){
        AudioClip clip;
        for(int i = 0; i < AudioObjects.Count; i++){
            if(audioObjects[i].clip){
                clip = AudioObjects[i].clip;
            }
        }
            return null;
    }
    }
}

