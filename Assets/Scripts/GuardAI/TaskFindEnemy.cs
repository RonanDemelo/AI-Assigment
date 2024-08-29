using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskFindEnemy : Node
{
    public TaskFindEnemy()
    {

    }

    public override NodeState Evaluate()
    {
        Debug.Log("Finding Enemy");
        state = NodeState.RUNNING;
        return state;
    }
}