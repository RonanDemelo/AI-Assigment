using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskHeal : Node
{

    public TaskHeal()
    {

    }

    public override NodeState Evaluate()
    {

        Debug.Log("Healing");
        state = NodeState.RUNNING;
        return state;

    }
}
