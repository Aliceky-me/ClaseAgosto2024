using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIExample : MonoBehaviour
{
    public TMP_Text scoreText;
    public Sprite eventSprite;

    void Update()
    {
        scoreText.text = PointsManager.instance.GetScore().ToString();
    }

    public void OnClick_AddPoints()
    {
        PointsManager.instance.AddPoints(10);
    }

    public void OnClick_RemovePoints()
    {
        PointsManager.instance.RemovePoints(10);
    }

    public void OnClick_NoLlegoElProfeEvent(){
        object[] parameters = new object[3];
        parameters[0] = "motores de juegos 2";
        parameters[1] = Color.red;
        parameters[2] = eventSprite;
        EventManager.m_Instance.InvokeEvent<NoLlegoElProfeEvent>(new NoLlegoElProfeEvent(parameters));
        EventManager.m_Instance.InvokeEvent<HayExamenEvent>(new HayExamenEvent());

    }
}
 