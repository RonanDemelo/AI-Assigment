using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskFindHealing : Node
{
    public TaskFindHealing()
    {

    }

    public override NodeState Evaluate()
    {
        Debug.Log("Finding Healing");
        state = NodeState.RUNNING;
        return state;
    }
}
