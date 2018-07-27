using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Execute all children until a child returns a success state.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Selector : BranchNode
    {

        protected override NodeState Execute()
        {
            while (true)
            {
                switch (ExecuteNode(ActiveChild))
                {

                    case NodeState.Failure:
                    case NodeState.NoResult:
                        break;
                    case NodeState.Success:
                        Reset();
                        return NodeState.Success;
                    case NodeState.ContinueNextFrame:
                        Reset();
                        return NodeState.ContinueNextFrame;
                }
                if (NextChild())
                    continue;
                else
                    return NodeState.Failure;
            }
        }

        public static string GetMenuPath()
        {
            return "Selector _s";
        }
    }

}
