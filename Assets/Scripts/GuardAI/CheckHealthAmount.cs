using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckHealthAmount : Node
{

    public bool healthLow = false;

    public CheckHealthAmount()
    {

    }

    public override NodeState Evaluate()
    {
        if(healthLow == true)
        {
            state = NodeState.SUCCESS;
            Debug.Log("I need to heal");
            return state;
        }

        state = NodeState.FAILURE;
        Debug.Log("I have enough HP");
        return state;
    }
}
