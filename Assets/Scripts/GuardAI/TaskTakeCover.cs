using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskTakeCover : Node
{
    public TaskTakeCover()
    {

    }

    public override NodeState Evaluate()
    {
        Debug.Log("Taking Cover");
        state = NodeState.RUNNING;
        return state;
    }
}
