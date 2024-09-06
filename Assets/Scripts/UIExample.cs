using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIExample : MonoBehaviour
{
    public TMP_Text scoreText;

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
}
 