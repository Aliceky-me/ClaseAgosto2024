using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Screen{
    public string screenName;
    public GameObject screen;
}
public class ScreenManager : MonoBehaviour
{

    private static ScreenManager _instance;
    public static ScreenManager instance{
        get{
            if(_instance == null){
                _instance = GameObject.FindObjectOfType<ScreenManager>();
            }
            return _instance;
        }
    }

    public List<Screen> screens;

    public void OpenScreen(string _screenName){
        //Paso 1. Cerrar todas las pantallas
        

        //Paso 2. Prender la pantalla del nombre
    }
}
