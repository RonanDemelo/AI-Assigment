using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckEnemyInFOVRange : Node
{
    private bool rangeEnemy = true;
    private bool target = true;

    public CheckEnemyInFOVRange()
    {
        
    }

    public override NodeState Evaluate()
    {

        if (target == true)
        {
            if (rangeEnemy == true)
            {
                state = NodeState.SUCCESS;
                Debug.Log("Enemy in range");
                return state;
            }
            state = NodeState.FAILURE;
            Debug.Log("Enemy not in range");
        }

        state = NodeState.FAILURE;
        return state;

    }

}
