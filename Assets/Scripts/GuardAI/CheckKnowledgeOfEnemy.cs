using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BehaviorTree;

public class CheckKnowledgeOfEnemy : Node
{
    private bool enemyLocation = true;

    public CheckKnowledgeOfEnemy()
    {

    }

    public override NodeState Evaluate()
    {
        if (enemyLocation == true)
        {
            Debug.Log("I know where the enemy is");
            state = NodeState.SUCCESS;
            return state;
        }

        Debug.Log("I dont know where the enemy is");
        state = NodeState.FAILURE;
        return state;

    }
}
