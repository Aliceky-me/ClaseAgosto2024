using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager _instance;
    private object[] chismoso;
    public delegate void EventDelegate<T>(T e) where T : GameEvent;


    public static ItemManager instance
    {
        get{
            if (_instance == null){
                _instance = GameObject.FindObjectOfType<ItemManager>();
            }
            return _instance;
        }
    }

    public void SpawnCircle()
    {
        EventManager.m_Instance.InvokeEvent<SpawnItem_Event>(new SpawnItem_Event());
    }


}
