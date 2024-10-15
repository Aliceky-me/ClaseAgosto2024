using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterDecision : AIDecision
{
    private bool hasPlayerEnter;

    public override void Initialization()
    {
        hasPlayerEnter = false;
    }
    public override bool Decide()
    {
        return hasPlayerEnter;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasPlayerEnter = true;

            _brain.Target = other.transform;
        }
    }

    private void OnTriggerExit()
    {
        base.OnExitState();
        hasPlayerEnter = false;
    }

    
}
