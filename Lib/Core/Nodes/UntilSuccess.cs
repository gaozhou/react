using System.Collections;
using System.Collections.Generic;

namespace DifferentMethods.React
{

    /// <summary>
    /// Tries to executes child until a success state is received.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class UntilSuccess : DecoratorNode
    {

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.NoResult;
            var result = ExecuteNode(Child);
            if (result == NodeState.Success)
                return result;
            else
                return NodeState.ContinueNextFrame;
        }

        public override string ToString()
        {
            return "Until Success";
        }

        public static string GetMenuPath()
        {
            return "Until/Success";
        }
    }

}
