using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetAction : AIAction
{
    public abstract void PerformAction()
    {
        if(_brain.Target != null){
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _brain.Target.position, step);
        }
    }

}
