using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskRunAway : Node
{
    public TaskRunAway()
    { 

    }

    public override NodeState Evaluate()
    {
        Debug.Log("Running Away");
        state = NodeState.RUNNING;
        return state;
    }
}
