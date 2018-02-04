using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// This decorator will execute it's child when the OnStart message is received.
    /// </summary>
    [System.Serializable]
    [CoreDecorator(0)]
    public class OnStart : DecoratorNode
    {
        protected override NodeState Execute()
        {
            if (Child != null)
            {
                Context = ReactContext.New(this);
                Context.Update(Reactor.gameObject);
                Reactor.QueueForExecution(Child);
            }
            return NodeState.Continue;
        }
    }

}