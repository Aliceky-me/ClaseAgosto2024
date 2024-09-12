using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alumno : MonoBehaviour
{
    public Image image;
    void Start()
    {
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
        EventManager.m_Instance.AddListener<HayExamenEvent>(Reprobar);

    }

    // Update is called once per frame
    public void MeVoyACasa(NoLlegoElProfeEvent _event){
        Debug.Log(_event.GetParameters()[0]);
        image.color = (Color)_event.GetParameters()[1];
        image.sprite = (Sprite)_event.GetParameters()[2];
    }

    public void Reprobar(HayExamenEvent _event){
        Debug.Log("TRISTE");
    }
}
