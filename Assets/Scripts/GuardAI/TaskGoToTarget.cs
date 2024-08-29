using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskGoToTarget : Node
{
    public TaskGoToTarget()
    {

    }

    public override NodeState Evaluate()
    {

        Debug.Log("Moving towards target");
        state = NodeState.RUNNING;
        return state;

    }
}
