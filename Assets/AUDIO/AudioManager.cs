using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]

public class AudioObject{
    public string ID;
    public AudioClip clip;
}


public class AudioManager : MonoBehaviour
{
    public List<AudioObject> AudioObjects;
}
