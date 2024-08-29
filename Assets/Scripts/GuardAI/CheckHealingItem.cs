using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckHealingItem : Node
{
    public bool healingItem = true;

    public CheckHealingItem()
    {

    }

    public override NodeState Evaluate()
    {
        if (healingItem == true)
        {
            state = NodeState.SUCCESS;
            Debug.Log("I Have healing");
            return state;
        }

        state = NodeState.FAILURE;
        Debug.Log("I need to find healing item");
        return state;
    }
}