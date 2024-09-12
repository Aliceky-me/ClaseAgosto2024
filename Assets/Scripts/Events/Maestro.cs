using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maestro : MonoBehaviour
{
    public Image image;
    void Start()
    {
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
    }

    // Update is called once per frame
    public void MeVoyACasa(NoLlegoElProfeEvent _event){
        Debug.Log(_event.GetParameters()[0]);
        image.sprite = (Sprite)_event.GetParameters()[2];
    }
}
