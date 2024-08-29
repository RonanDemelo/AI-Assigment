using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskPatrol : Node
{

    public TaskPatrol()
    {
        
    }

    public override NodeState Evaluate()
    {

        Debug.Log("Patroling");
        state = NodeState.RUNNING;
        return state;
        
    }
}
