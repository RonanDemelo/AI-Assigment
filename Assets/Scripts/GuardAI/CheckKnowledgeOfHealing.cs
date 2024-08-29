using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckKnowledgeOfHealing : Node
{
    private bool healingLocation = true;

    public CheckKnowledgeOfHealing()
    {

    }

    public override NodeState Evaluate()
    {
        if (healingLocation == true)
        {
            Debug.Log("I know where i can find heal item");
            state = NodeState.SUCCESS;
            return state;
        }
        Debug.Log("I dont know where i can heal");
        state = NodeState.FAILURE;
        return state;

    }
}
