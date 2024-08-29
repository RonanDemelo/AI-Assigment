using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class TaskAttack : Node
{
    public TaskAttack()
    {

    }

    public override NodeState Evaluate()
    {
        Debug.Log("Attacking target");
        state = NodeState.RUNNING;
        return state;
    }
}
