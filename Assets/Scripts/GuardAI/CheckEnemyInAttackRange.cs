using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckEnemyInAttackRange : Node
{
    private bool enemyClose = true;
    private bool target = true;

    public CheckEnemyInAttackRange()
    {

    }

    public override NodeState Evaluate()
    {
        if(target == false)
        {
            state = NodeState.FAILURE;
            Debug.Log("Enemy is too far to attack");
            return state;

        }

        
        if(enemyClose == true)
        {
            Debug.Log("Enemy is close to attack");
            state = NodeState.SUCCESS;
            return state;
        }

        Debug.Log("Enemy is too far to attack");
        state = NodeState.FAILURE;
        return state;

    }
}
