using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckCover : Node
{

    public bool cover = false;

    public CheckCover()
    {

    }

    public override NodeState Evaluate()
    {
        if (cover == true)
        {
            state = NodeState.SUCCESS;
            Debug.Log("Theres cover");
            return state;
        }

        state = NodeState.FAILURE;
        Debug.Log("No cover");
        return state;
    }
}