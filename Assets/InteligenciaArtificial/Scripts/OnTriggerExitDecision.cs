using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool hasPlayerExit;

    public override void Initialization(){
        hasPlayerExit = false;
    }
    public override bool Decide(){
        return hasPlayerExit;
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player" && _brain.Target != null){
            hasPlayerExit = true;
            _brain.Target = null; 
        }
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerExit = false;
    }
}
