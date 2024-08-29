using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class Invertor : Node
    {
        protected Node node;

        public Invertor(Node child)
        {
            this.node = child;
        }


        public override NodeState Evaluate()
        {
            bool anyChildIsRunning = false;

            switch (node.Evaluate())
            {
                case NodeState.FAILURE:
                    state = NodeState.SUCCESS;
                    return state;
                case NodeState.SUCCESS:
                    state = NodeState.FAILURE;
                    return state;
                case NodeState.RUNNING:
                    anyChildIsRunning = true;
                    break;
                default:
                    break;
            }
            state = anyChildIsRunning ? NodeState.RUNNING : NodeState.SUCCESS;
            return state;
        }
    }
}
